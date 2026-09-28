using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Modelo.Modelo.Infraestructura
{
    public static class CatalogoErrores
    {
        public sealed class Entrada
        {
            public string Codigo { get; private set; }
            public string Categoria { get; private set; }
            public string Mensaje { get; private set; }
            public string Accion { get; private set; }

            public Entrada(string codigo, string categoria, string mensaje, string accion)
            {
                Codigo = codigo;
                Categoria = categoria;
                Mensaje = mensaje;
                Accion = accion;
            }
        }

        private static readonly Dictionary<string, Entrada> entradas = CrearEntradas();

        private static Dictionary<string, Entrada> CrearEntradas()
        {
            Dictionary<string, Entrada> resultado = new Dictionary<string, Entrada>();
            resultado.Add("ERR-SQL-001", new Entrada("ERR-SQL-001", "SQL Server", "Servidor SQL no disponible.", "Compruebe la instancia y la conectividad."));
            resultado.Add("ERR-SQL-002", new Entrada("ERR-SQL-002", "SQL Server", "Base de datos no disponible.", "Compruebe el nombre de la base de datos y los permisos."));
            resultado.Add("ERR-SQL-003", new Entrada("ERR-SQL-003", "SQL Server", "La conexión a SQL Server rechazó las credenciales.", "Verifique la cuenta y el modo de autenticación."));
            resultado.Add("ERR-SQL-004", new Entrada("ERR-SQL-004", "SQL Server", "Ya existe un registro con esos datos.", "Revise los valores únicos antes de volver a guardar."));
            resultado.Add("ERR-SQL-005", new Entrada("ERR-SQL-005", "SQL Server", "No se puede completar la operación porque hay datos relacionados o restricciones de integridad.", "Verifique relaciones y restricciones del registro."));
            resultado.Add("ERR-SQL-006", new Entrada("ERR-SQL-006", "SQL Server", "Falta información obligatoria en la base de datos.", "Revise los campos requeridos y el esquema."));
            resultado.Add("ERR-SQL-007", new Entrada("ERR-SQL-007", "SQL Server", "No fue posible procesar una consulta SQL.", "Revise la consulta utilizada y sus parámetros."));
            resultado.Add("ERR-SQL-008", new Entrada("ERR-SQL-008", "SQL Server", "Se interrumpió la comunicación o se agotó el tiempo de espera de SQL Server.", "Compruebe la red y el servicio; vuelva a intentarlo."));
            resultado.Add("ERR-SQL-009", new Entrada("ERR-SQL-009", "SQL Server", "La estructura de la base de datos no coincide con la versión de la aplicación.", "Cree DbSyncore con el Estructura.sql de esta versión y vuelva a intentarlo."));
            resultado.Add("ERR-SQL-010", new Entrada("ERR-SQL-010", "SQL Server", "Los parámetros enviados a una consulta no coinciden con los esperados.", "Revise la versión de la aplicación y de la base de datos."));
            resultado.Add("ERR-SQL-011", new Entrada("ERR-SQL-011", "SQL Server", "Un dato no puede convertirse o está fuera del rango permitido por la base de datos.", "Revise los datos utilizados en la operación."));
            resultado.Add("ERR-SQL-012", new Entrada("ERR-SQL-012", "SQL Server", "Un texto supera la longitud permitida por la base de datos.", "Reduzca el contenido e inténtelo nuevamente."));
            resultado.Add("ERR-SQL-013", new Entrada("ERR-SQL-013", "SQL Server", "La operación fue cancelada por un bloqueo entre transacciones.", "Vuelva a intentar la operación."));
            resultado.Add("ERR-SQL-014", new Entrada("ERR-SQL-014", "SQL Server", "La operación esperó demasiado tiempo por un registro bloqueado.", "Espere un momento y vuelva a intentarlo."));
            resultado.Add("ERR-SQL-015", new Entrada("ERR-SQL-015", "SQL Server", "La cuenta utilizada no tiene permisos para ejecutar la operación.", "Revise los permisos de acceso a la base de datos."));
            resultado.Add("ERR-SQL-999", new Entrada("ERR-SQL-999", "SQL Server", "Ocurrió un error de base de datos no catalogado.", "Anote el código y contacte al responsable técnico."));
            resultado.Add("ERR-VAL-001", new Entrada("ERR-VAL-001", "Validación", "Falta un dato obligatorio.", "Complete el campo señalado."));
            resultado.Add("ERR-VAL-002", new Entrada("ERR-VAL-002", "Validación", "El formato o el tipo de dato no es válido.", "Corrija los caracteres y el tipo de dato."));
            resultado.Add("ERR-VAL-003", new Entrada("ERR-VAL-003", "Validación", "El valor está fuera del rango permitido.", "Revise los límites del campo."));
            resultado.Add("ERR-VAL-004", new Entrada("ERR-VAL-004", "Validación", "Los datos no son consistentes entre sí.", "Compruebe fechas, avance o confirmación de contraseña."));
            resultado.Add("ERR-VAL-005", new Entrada("ERR-VAL-005", "Validación", "El valor ya está registrado.", "Utilice un valor diferente."));
            resultado.Add("ERR-VAL-006", new Entrada("ERR-VAL-006", "Validación", "El archivo o la imagen no cumple los requisitos.", "Seleccione un archivo válido dentro del límite permitido."));
            resultado.Add("ERR-VAL-007", new Entrada("ERR-VAL-007", "Validación", "La selección no es válida.", "Seleccione una opción disponible."));
            resultado.Add("ERR-VAL-999", new Entrada("ERR-VAL-999", "Validación", "La información ingresada no es válida.", "Revise los datos marcados."));
            resultado.Add("ERR-NEG-001", new Entrada("ERR-NEG-001", "Regla de negocio", "Esta operación no está permitida para el usuario actual.", "Compruebe los permisos y el estado del registro."));
            resultado.Add("ERR-NEG-002", new Entrada("ERR-NEG-002", "Regla de negocio", "Las credenciales proporcionadas no son válidas.", "Revise el usuario y la contraseña."));
            resultado.Add("ERR-NEG-003", new Entrada("ERR-NEG-003", "Regla de negocio", "No se cumplen los requisitos para realizar esta operación.", "Compruebe el estado de la tarea, proyecto o integrante."));
            resultado.Add("ERR-NEG-004", new Entrada("ERR-NEG-004", "Regla de negocio", "No existen registros para realizar la operación solicitada.", "Modifique los filtros o registre información."));
            resultado.Add("ERR-APP-001", new Entrada("ERR-APP-001", "Aplicación y archivos", "No fue posible abrir o leer el archivo seleccionado.", "Compruebe que el archivo exista y esté disponible."));
            resultado.Add("ERR-APP-002", new Entrada("ERR-APP-002", "Aplicación y archivos", "No fue posible guardar o exportar el archivo.", "Compruebe la ubicación y los permisos."));
            resultado.Add("ERR-APP-003", new Entrada("ERR-APP-003", "Aplicación y archivos", "No es posible continuar sin conexión al servidor.", "Verifique el servicio y la configuración."));
            resultado.Add("ERR-APP-004", new Entrada("ERR-APP-004", "Aplicación y archivos", "No fue posible abrir la ayuda del sistema.", "Compruebe que el enlace del manual sea válido y esté disponible."));
            return resultado;
        }

        public static Entrada Obtener(string codigo)
        {
            if (string.IsNullOrEmpty(codigo) == false && entradas.ContainsKey(codigo))
            {
                return entradas[codigo];
            }
            return entradas["ERR-VAL-999"];
        }

        public static string CodigoSql(int numero)
        {
            if (numero == 2 || numero == 26 || numero == 53)
            {
                return "ERR-SQL-001";
            }
            else if (numero == 4060)
            {
                return "ERR-SQL-002";
            }
            else if (numero == 18456)
            {
                return "ERR-SQL-003";
            }
            else if (numero == 2601 || numero == 2627)
            {
                return "ERR-SQL-004";
            }
            else if (numero == 547)
            {
                return "ERR-SQL-005";
            }
            else if (numero == 515)
            {
                return "ERR-SQL-006";
            }
            else if (numero == 102 || numero == 156)
            {
                return "ERR-SQL-007";
            }
            else if (numero == 207 || numero == 208 || numero == 2812)
            {
                return "ERR-SQL-009";
            }
            else if (numero == 201 || numero == 8144 || numero == 8145)
            {
                return "ERR-SQL-010";
            }
            else if (numero == 245 || numero == 8114 || numero == 8115)
            {
                return "ERR-SQL-011";
            }
            else if (numero == 2628 || numero == 8152)
            {
                return "ERR-SQL-012";
            }
            else if (numero == 1205)
            {
                return "ERR-SQL-013";
            }
            else if (numero == 1222)
            {
                return "ERR-SQL-014";
            }
            else if (numero == 229)
            {
                return "ERR-SQL-015";
            }
            else if (numero == 64 || numero == 121 || numero == 233 || numero == 258 || numero == 10053 || numero == 10054 || numero == 10060 || numero == -2)
            {
                return "ERR-SQL-008";
            }
            return "ERR-SQL-999";
        }

        public static void MarcarCampo(ErrorProvider proveedor, Control campo, string codigo, string detalle)
        {
            Entrada entrada = Obtener(codigo);
            if (string.IsNullOrWhiteSpace(detalle))
            {
                proveedor.SetError(campo, entrada.Codigo + " - " + entrada.Mensaje);
            }
            else
            {
                proveedor.SetError(campo, entrada.Codigo + " - " + detalle);
            }
        }

        public static void MostrarDetalle(string codigo, string titulo, string detalle)
        {
            Entrada entrada = Obtener(codigo);
            MessageBoxIcon icono = MessageBoxIcon.Warning;
            if (entrada.Categoria == "SQL Server" || entrada.Categoria == "Aplicación y archivos")
            {
                icono = MessageBoxIcon.Error;
            }
            string mensaje = entrada.Codigo + " - " + entrada.Mensaje;
            if (string.IsNullOrWhiteSpace(detalle) == false && detalle != entrada.Mensaje)
            {
                mensaje = mensaje + Environment.NewLine + detalle;
            }
            MessageBox.Show(mensaje + Environment.NewLine + entrada.Accion,
                titulo, MessageBoxButtons.OK, icono);
        }

        public static void Mostrar(string codigo, string titulo)
        {
            Entrada entrada = Obtener(codigo);
            MessageBoxIcon icono = MessageBoxIcon.Warning;
            if (entrada.Categoria == "SQL Server" || entrada.Categoria == "Aplicación y archivos")
            {
                icono = MessageBoxIcon.Error;
            }
            MessageBox.Show(entrada.Codigo + " - " + entrada.Mensaje + Environment.NewLine + entrada.Accion,
                titulo, MessageBoxButtons.OK, icono);
        }
    }
}
