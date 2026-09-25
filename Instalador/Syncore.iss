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
[Icons]
Name: "{group}\Syncore"; Filename: "{app}\Vista.exe"
Name: "{commondesktop}\Syncore"; Filename: "{app}\Vista.exe"; Tasks: desktopicon
[Tasks]
Name: desktopicon; Description: "Crear acceso directo en el escritorio"; GroupDescription: "Accesos directos:"
[Code]
function FrameworkDisponible(): Boolean;
var Release: Cardinal;
begin
  Release := 0;
  Result := RegQueryDWordValue(HKLM, 'SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full', 'Release', Release);
  if Result then
    Result := Release >= 461808;
end;
function InitializeSetup(): Boolean;
begin
  Result := FrameworkDisponible();
  if not Result then
    MsgBox('Syncore requiere .NET Framework 4.7.2 o superior. Instálelo antes de continuar.', mbError, MB_OK);
end;
