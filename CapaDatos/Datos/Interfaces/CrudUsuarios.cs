﻿using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Interfaces
{
    public interface CrudUsuarios
    {
        bool AltaUsuario(Usuarios u);
        bool ModificarUsuario(Usuarios u);
        List<Usuarios> ObtenerUsuarios();
    }
}
