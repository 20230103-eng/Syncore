using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelo.Modelo.Infraestructura;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmAgregarIntegrante : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private EquipoProyecto equipoModelo;
        private RolProyecto rolProyectoModelo;
        private Dictionary<int, int> usuariosSeleccionados;
        private DataTable rolesDisponibles;

        public int IdProyecto { get; set; }

        public frmAgregarIntegrante()
        {
            InitializeComponent();
            toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            errorProviderValidacion.ContainerControl = this;
            errorProviderValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            toolTipAyuda.SetToolTip(txtBuscar, "Escriba el texto que desea buscar.");
            toolTipAyuda.SetToolTip(btnBuscar, "Buscar según el criterio ingresado.");
            toolTipAyuda.SetToolTip(btnCancelar, "Cancelar la operación actual.");
            toolTipAyuda.SetToolTip(btnAgregar, "Agregar el elemento seleccionado.");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);
            btnCancelar.Click += btnCancelar_Click;
            usuariosSeleccionados = new Dictionary<int, int>();
            ucPaginador.PaginaCambiada += ucPaginador_PaginaCambiada;
        }

        private void frmAgregarIntegrante_Load(object sender, EventArgs e)
        {
            equipoModelo = new EquipoProyecto();
            rolProyectoModelo = new RolProyecto();
            rolesDisponibles = rolProyectoModelo.ObtenerRolesActivos();
            ucPaginador.Configurar(0, true);
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            DataTable usuarios;
            int total;
            string texto;

            flpUsuarios.Controls.Clear();
            texto = txtBuscar.Text.Trim();
            int paginaAnterior = ucPaginador.Inicio / UCPaginadorTarjetas.RegistrosPorPagina;
            usuarios = equipoModelo.ObtenerUsuariosDisponiblesPagina(IdProyecto, texto,
                paginaAnterior, out total);
            ucPaginador.Configurar(total, false);
            if (ucPaginador.Inicio / UCPaginadorTarjetas.RegistrosPorPagina != paginaAnterior)
            {
                CargarUsuarios();
                return;
            }
            lblResultados.Text = total.ToString() + " disponibles; " + usuariosSeleccionados.Count.ToString() + " seleccionados";

            foreach (DataRow fila in usuarios.Rows)
            {
                UCTarjetaSeleccionUsuario control;

                control = new UCTarjetaSeleccionUsuario();
                control.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
                control.Usuario = fila["NombreUsuario"].ToString();
                control.NombreCompleto = fila["NombreCompleto"].ToString();
                control.Seleccionado = false;
                control.CargarRoles(rolesDisponibles);
                if (usuariosSeleccionados.ContainsKey(control.IdUsuario))
                {
                    control.Seleccionado = true;
                    if (usuariosSeleccionados[control.IdUsuario] > 0)
                    {
                        control.SeleccionarRol(usuariosSeleccionados[control.IdUsuario]);
                    }
                }
                control.Width = flpUsuarios.ClientSize.Width - 4;
                control.SeleccionCambiada += Usuarios_SeleccionCambiada;
                flpUsuarios.Controls.Add(control);
            }

            if (usuarios.Rows.Count == 0)
            {
                Label mensaje;

                mensaje = new Label();
                mensaje.AutoSize = false;
                mensaje.Width = flpUsuarios.ClientSize.Width - 10;
                mensaje.Height = 45;
                mensaje.Text = "No hay usuarios disponibles.";
                mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                flpUsuarios.Controls.Add(mensaje);
            }
        }

        private bool ValidarSeleccion()
        {
            errorProviderValidacion.Clear();
            if (usuariosSeleccionados.Count == 0)
            {
                CatalogoErrores.MarcarCampo(errorProviderValidacion, flpUsuarios, "ERR-VAL-007", "Seleccione al menos un usuario.");
                CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Syncore", "Seleccione al menos un usuario.");
                return false;
            }
            foreach (KeyValuePair<int, int> seleccionado in usuariosSeleccionados)
            {
                if (seleccionado.Value <= 0)
                {
                    CatalogoErrores.MarcarCampo(errorProviderValidacion, flpUsuarios, "ERR-VAL-007", "Asigne un rol a cada usuario seleccionado.");
                    CatalogoErrores.MostrarDetalle("ERR-VAL-007", "Integrantes", "Todos los usuarios seleccionados deben tener un rol.");
                    return false;
                }
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ucPaginador.Configurar(0, true);
            CargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool datosCorrectos;
            bool todosAgregados;

            datosCorrectos = ValidarSeleccion();

            if (datosCorrectos == false)
            {
                return;
            }

            todosAgregados = true;

            List<int> agregados = new List<int>();
            foreach (KeyValuePair<int, int> seleccionado in usuariosSeleccionados)
            {
                EquipoProyecto integrante = new EquipoProyecto();
                integrante.IdProyecto = IdProyecto;
                integrante.IdUsuario = seleccionado.Key;
                integrante.IdRolProyecto = seleccionado.Value;
                integrante.FechaAsignacion = DateTime.Now;
                integrante.Activo = true;
                if (integrante.AgregarIntegrante())
                {
                    agregados.Add(seleccionado.Key);
                }
                else
                {
                    todosAgregados = false;
                }
            }
            for (int indice = 0; indice < agregados.Count; indice = indice + 1)
            {
                usuariosSeleccionados.Remove(agregados[indice]);
            }

            if (todosAgregados == true)
            {
                MessageBox.Show("Los integrantes fueron agregados correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                CatalogoErrores.MostrarDetalle("ERR-NEG-003", "Syncore", "Uno o más integrantes no pudieron agregarse.");
                CargarUsuarios();
            }
        }
        private void ucPaginador_PaginaCambiada(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void Usuarios_SeleccionCambiada(object sender, EventArgs e)
        {
            UCTarjetaSeleccionUsuario control = sender as UCTarjetaSeleccionUsuario;
            if (control == null)
            {
                return;
            }
            if (control.Seleccionado)
            {
                usuariosSeleccionados[control.IdUsuario] = control.IdRolProyecto;
            }
            else
            {
                usuariosSeleccionados.Remove(control.IdUsuario);
            }
            lblResultados.Text = "Seleccionados: " + usuariosSeleccionados.Count.ToString();
            bool faltaRol = false;
            foreach (KeyValuePair<int, int> seleccionado in usuariosSeleccionados)
            {
                if (seleccionado.Value <= 0)
                {
                    faltaRol = true;
                }
            }
            if (usuariosSeleccionados.Count == 0)
                CatalogoErrores.MarcarCampo(errorProviderValidacion, flpUsuarios,
                    "ERR-VAL-007", "Seleccione al menos un usuario.");
            else if (faltaRol)
                CatalogoErrores.MarcarCampo(errorProviderValidacion, flpUsuarios,
                    "ERR-VAL-007", "Asigne un rol a los usuarios seleccionados.");
            else
                errorProviderValidacion.SetError(flpUsuarios, "");
        }

    }
}
