using System;
using System.Data;
using System.Windows.Forms;
using Modelo.Modelo.Entidades;

namespace Vista
{
    public partial class frmAgregarIntegrante : Form
    {
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;

        private EquipoProyecto equipoModelo;
        private RolProyecto rolProyectoModelo;

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
        }

        private void frmAgregarIntegrante_Load(object sender, EventArgs e)
        {
            equipoModelo = new EquipoProyecto();
            rolProyectoModelo = new RolProyecto();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            DataTable usuarios;
            DataTable roles;
            string texto;

            flpUsuarios.Controls.Clear();
            texto = txtBuscar.Text.Trim();
            usuarios = equipoModelo.ObtenerUsuariosDisponibles(IdProyecto, texto);
            roles = rolProyectoModelo.ObtenerRolesActivos();

            foreach (DataRow fila in usuarios.Rows)
            {
                UCTarjetaSeleccionUsuario control;

                control = new UCTarjetaSeleccionUsuario();
                control.IdUsuario = Convert.ToInt32(fila["IdUsuario"]);
                control.Usuario = fila["NombreUsuario"].ToString();
                control.NombreCompleto = fila["NombreCompleto"].ToString();
                control.Seleccionado = false;
                control.CargarRoles(roles);
                control.Width = flpUsuarios.ClientSize.Width - 4;
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
            int seleccionados;

            errorProviderValidacion.Clear();

            seleccionados = 0;

            foreach (Control controlBase in flpUsuarios.Controls)
            {
                UCTarjetaSeleccionUsuario control;

                control = controlBase as UCTarjetaSeleccionUsuario;

                if (control != null && control.Seleccionado == true)
                {
                    seleccionados = seleccionados + 1;

                    if (control.IdRolProyecto == 0)
                    {
                        errorProviderValidacion.SetError(flpUsuarios, "Seleccione el rol de los usuarios marcados.");
                        MessageBox.Show("Seleccione el rol de " + control.NombreCompleto + ".");
                        return false;
                    }
                }
            }

            if (seleccionados == 0)
            {
                errorProviderValidacion.SetError(flpUsuarios, "Seleccione al menos un usuario.");
                MessageBox.Show("Seleccione al menos un usuario.");
                return false;
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

            foreach (Control controlBase in flpUsuarios.Controls)
            {
                UCTarjetaSeleccionUsuario control;

                control = controlBase as UCTarjetaSeleccionUsuario;

                if (control != null && control.Seleccionado == true)
                {
                    EquipoProyecto integrante;
                    bool agregado;

                    integrante = new EquipoProyecto();
                    integrante.IdProyecto = IdProyecto;
                    integrante.IdUsuario = control.IdUsuario;
                    integrante.IdRolProyecto = control.IdRolProyecto;
                    integrante.FechaAsignacion = DateTime.Now;
                    integrante.Activo = true;
                    agregado = integrante.AgregarIntegrante();

                    if (agregado == false)
                    {
                        todosAgregados = false;
                    }
                }
            }

            if (todosAgregados == true)
            {
                MessageBox.Show("Los integrantes fueron agregados correctamente.");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Uno o más integrantes no pudieron agregarse.");
                CargarUsuarios();
            }
        }
    }
}
