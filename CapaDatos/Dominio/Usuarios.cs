using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Usuarios
    {
        public int ID_Usuario { get; set; }
        public string Alias { get; set; }
        public string Contraseña { get; set; }
        public int Id_Empleado { get; set; }
        public int Id_Rol { get; set; }
        public int Baja_Logica { get; set; }
    }
}
