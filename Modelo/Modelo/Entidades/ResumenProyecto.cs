using System;
using System.Data;

namespace Modelo.Modelo.Entidades
{
    public class ResumenProyecto
    {
        private int proyectosActivos;
        private int proyectosAtrasados;
        private decimal avancePromedio;

        public int ProyectosActivos
        {
            get
            {
                return proyectosActivos;
            }
            set
            {
                proyectosActivos = value;
            }
        }

        public int ProyectosAtrasados
        {
            get
            {
                return proyectosAtrasados;
            }
            set
            {
                proyectosAtrasados = value;
            }
        }

        public decimal AvancePromedio
        {
            get
            {
                return avancePromedio;
            }
            set
            {
                avancePromedio = value;
            }
        }

        public ResumenProyecto()
        {
        }

        public decimal BuscarAvanceReal(DataTable proyectos, int idProyecto)
        {
            decimal avanceReal;

            avanceReal = 0;

            foreach (DataRow fila in proyectos.Rows)
            {
                int idProyectoFila;

                idProyectoFila = Convert.ToInt32(fila["IdProyecto"]);

                if (idProyectoFila == idProyecto)
                {
                    avanceReal = Convert.ToDecimal(fila["AvanceReal"]);
                    break;
                }
            }

            return avanceReal;
        }

        public int ContarProyectosActivos(DataTable proyectos)
        {
            int cantidad;

            cantidad = 0;

            foreach (DataRow fila in proyectos.Rows)
            {
                string estado;

                estado = fila["Estado"].ToString();

                if (estado == "Activo")
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        public int ContarProyectosAtrasados(DataTable proyectos)
        {
            int cantidad;

            cantidad = 0;

            foreach (DataRow fila in proyectos.Rows)
            {
                decimal avancePlanificado;
                decimal avanceReal;

                avancePlanificado = Convert.ToDecimal(fila["AvancePlanificado"]);
                avanceReal = Convert.ToDecimal(fila["AvanceReal"]);

                if (avanceReal < avancePlanificado)
                {
                    cantidad = cantidad + 1;
                }
            }

            return cantidad;
        }

        public decimal CalcularAvancePromedio(DataTable proyectos)
        {
            decimal suma;
            decimal promedio;
            int cantidadProyectos;

            suma = 0;
            promedio = 0;
            cantidadProyectos = 0;

            foreach (DataRow fila in proyectos.Rows)
            {
                decimal avanceReal;

                avanceReal = Convert.ToDecimal(fila["AvanceReal"]);
                suma = suma + avanceReal;
                cantidadProyectos = cantidadProyectos + 1;
            }

            if (cantidadProyectos > 0)
            {
                promedio = suma / cantidadProyectos;
            }

            return promedio;
        }
    }
}
