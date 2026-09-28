#define AppNombre "Syncore"
#define AppVersion "1.0"
#define Salida "..\Vista\bin\Release"
[Setup]
AppId={{CA7BBF19-4E2A-4709-B08B-91AC2AF0E985}
AppName={#AppNombre}
AppVersion={#AppVersion}
DefaultDirName={autopf}\Syncore
DefaultGroupName=Syncore
OutputDir=SalidaInstalador
OutputBaseFilename=Syncore_Setup
Compression=lzma
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64compatible
PrivilegesRequired=admin
WizardStyle=modern
SetupIconFile=..\Vista\Recursos\Syncore.ico
UninstallDisplayIcon={app}\Vista.exe
[Files]
Source: "{#Salida}\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: "*.pdb,*.xml"
Source: "..\SQL\Estructura.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion
Source: "..\SQL\Insertar.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion
Source: "..\SQL\probarm.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion
Source: "..\SQL\BorrarConfiguracionEmpresa.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion
Source: "InstalarBaseDatos.ps1"; DestDir: "{app}\SQL"; Flags: ignoreversion
[Icons]
Name: "{group}\Syncore"; Filename: "{app}\Vista.exe"
Name: "{commondesktop}\Syncore"; Filename: "{app}\Vista.exe"; Tasks: desktopicon
[Tasks]
Name: desktopicon; Description: "Crear acceso directo en el escritorio"; GroupDescription: "Accesos directos:"
[Code]
var
  PaginaSql: TWizardPage;
  ComboInstancia: TNewComboBox;
  CasillaEjemplo: TNewCheckBox;
  EtiquetaAviso: TNewStaticText;

function FrameworkDisponible(): Boolean;
var Release: Cardinal;
begin
  Release := 0;
  Result := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Release);
  if Result then
    Result := Release >= 461808;
end;

function LeerInstancias(Raiz: Integer; Lista: TStrings): Boolean;
var
  Nombres: TArrayOfString;
  Indice: Integer;
begin
  Result := RegGetValueNames(Raiz, 'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL', Nombres);
  if Result then
  begin
    for Indice := 0 to GetArrayLength(Nombres) - 1 do
    begin
      if Nombres[Indice] = 'MSSQLSERVER' then
        Lista.Add('.')
      else
        Lista.Add('.\' + Nombres[Indice]);
    end;
  end;
end;

procedure CargarInstancias(Lista: TStrings);
begin
  Lista.Clear();
  if IsWin64 then
    LeerInstancias(HKLM64, Lista);
  if Lista.Count = 0 then
    LeerInstancias(HKLM, Lista);
end;

function HaySqlServer(): Boolean;
var Lista: TStringList;
begin
  Lista := TStringList.Create();
  try
    CargarInstancias(Lista);
    Result := Lista.Count > 0;
  finally
    Lista.Free();
  end;
end;

function InitializeSetup(): Boolean;
begin
  Result := FrameworkDisponible();
  if not Result then
  begin
    MsgBox('Syncore requiere .NET Framework 4.7.2 o superior. Instalelo antes de continuar.', mbError, MB_OK);
    Exit;
  end;

  Result := HaySqlServer();
  if not Result then
    MsgBox('Syncore requiere SQL Server instalado en este equipo o una instancia local accesible.' + #13#10 +
           'No se detecto ninguna instancia de SQL Server. Instale SQL Server y vuelva a ejecutar este instalador.',
           mbError, MB_OK);
end;

procedure InitializeWizard();
var Lista: TStringList;
begin
  PaginaSql := CreateCustomPage(wpSelectTasks, 'Base de datos',
    'Elija la instancia de SQL Server donde se creara DbSyncore.');

  EtiquetaAviso := TNewStaticText.Create(PaginaSql);
  EtiquetaAviso.Parent := PaginaSql.Surface;
  EtiquetaAviso.Left := 0;
  EtiquetaAviso.Top := 0;
  EtiquetaAviso.Width := PaginaSql.SurfaceWidth;
  EtiquetaAviso.WordWrap := True;
  EtiquetaAviso.Caption := 'Se usara autenticacion de Windows. Si la base DbSyncore ya existe, no se modificara.';

  ComboInstancia := TNewComboBox.Create(PaginaSql);
  ComboInstancia.Parent := PaginaSql.Surface;
  ComboInstancia.Left := 0;
  ComboInstancia.Top := EtiquetaAviso.Top + EtiquetaAviso.Height + 16;
  ComboInstancia.Width := PaginaSql.SurfaceWidth;
  ComboInstancia.Style := csDropDown;

  Lista := TStringList.Create();
  try
    CargarInstancias(Lista);
    ComboInstancia.Items.Assign(Lista);
  finally
    Lista.Free();
  end;

  if ComboInstancia.Items.Count > 0 then
    ComboInstancia.ItemIndex := 0;

  CasillaEjemplo := TNewCheckBox.Create(PaginaSql);
  CasillaEjemplo.Parent := PaginaSql.Surface;
  CasillaEjemplo.Left := 0;
  CasillaEjemplo.Top := ComboInstancia.Top + ComboInstancia.Height + 16;
  CasillaEjemplo.Width := PaginaSql.SurfaceWidth;
  CasillaEjemplo.Caption := 'Insertar datos de ejemplo (usuarios y proyectos de prueba)';
  CasillaEjemplo.Checked := True;
end;

function NextButtonClick(PaginaActual: Integer): Boolean;
begin
  Result := True;
  if PaginaActual = PaginaSql.ID then
  begin
    if Trim(ComboInstancia.Text) = '' then
    begin
      MsgBox('Escriba o elija la instancia de SQL Server.', mbError, MB_OK);
      Result := False;
    end;
  end;
end;

procedure PrepararBaseDatos();
var
  Comando: String;
  Ejemplo: String;
  Registro: String;
  Codigo: Integer;
begin
  Registro := ExpandConstant('{app}\SQL\InstalacionBaseDatos.log');

  if CasillaEjemplo.Checked then
    Ejemplo := 'si'
  else
    Ejemplo := 'no';

  Comando := '/C powershell.exe -NoProfile -ExecutionPolicy Bypass -File "' +
    ExpandConstant('{app}\SQL\InstalarBaseDatos.ps1') + '"' +
    ' -Servidor "' + Trim(ComboInstancia.Text) + '"' +
    ' -CarpetaSql "' + ExpandConstant('{app}\SQL') + '"' +
    ' -ArchivoConfig "' + ExpandConstant('{app}\Vista.exe.config') + '"' +
    ' -InsertarEjemplo ' + Ejemplo +
    ' > "' + Registro + '" 2>&1';

  WizardForm.StatusLabel.Caption := 'Preparando la base de datos DbSyncore...';

  if not Exec(ExpandConstant('{cmd}'), Comando, '', SW_HIDE, ewWaitUntilTerminated, Codigo) then
  begin
    MsgBox('No se pudo iniciar la preparacion de la base de datos.' + #13#10 +
           'Ejecute despues, como administrador:' + #13#10 +
           ExpandConstant('{app}\SQL\InstalarBaseDatos.ps1'), mbError, MB_OK);
    Exit;
  end;

  if Codigo = 1 then
    MsgBox('Syncore se instalo, pero no se pudo conectar a SQL Server en ' + Trim(ComboInstancia.Text) + '.' + #13#10 +
           'Revise el detalle en:' + #13#10 + Registro, mbError, MB_OK)
  else if Codigo = 2 then
    MsgBox('Syncore se instalo, pero fallo la creacion de la base de datos.' + #13#10 +
           'Revise el detalle en:' + #13#10 + Registro, mbError, MB_OK)
  else if Codigo = 3 then
    MsgBox('Syncore se instalo, pero no se encontraron los scripts SQL.' + #13#10 +
           'Revise el detalle en:' + #13#10 + Registro, mbError, MB_OK);
end;

procedure CurStepChanged(PasoActual: TSetupStep);
begin
  if PasoActual = ssPostInstall then
    PrepararBaseDatos();
end;
