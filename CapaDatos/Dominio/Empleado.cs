using CapaDatos.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Empleado
    {
        public int Id_Empleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public long DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Baja_logica { get; set; }
        public string NombreCompleto { get; set; }
        public int Altura { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public Localidad Loc { get; set; }
    }
}
