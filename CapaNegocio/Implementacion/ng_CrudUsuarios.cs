using CapaDatos.Datos.Implementacion;
using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using CapaNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Implementacion
{
    public class ng_CrudUsuarios : ing_CrudUsuarios
    {
        private CrudUsuarios lg;

        public ng_CrudUsuarios()
        {
            lg = new Im_CrudUsuarios();
        }
        public bool AltaUsuario(Usuarios u)
        {
            return lg.AltaUsuario(u);
        }

        public bool BuscarUsuario(int id)
        {
            return lg.BuscarUsuario(id);
        }

        public bool ModificarUsuario(Usuarios u)
        {
            return lg.ModificarUsuario(u);
        }

        public List<Usuarios> ObtenerUsuarios(int a)
        {
            return lg.ObtenerUsuarios(a);
        }
    }
}
