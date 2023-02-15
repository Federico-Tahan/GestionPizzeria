﻿using CapaDatos.Datos.Interfaces;
using CapaDatos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Datos.Implementacion
{
    public class Im_CrudUsuarios : CrudUsuarios
    {
        Encriptacion encrypt = new Encriptacion();
        public bool AltaUsuario(Usuarios u, Usuarios admin)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", u.Empleado.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", u.Empleado.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", u.Empleado.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", u.Empleado.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_nacimiento", u.Empleado.FechaNacimiento);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", u.Empleado.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@alias", u.Alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", encrypt.Encriptar(u.Contraseña));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rol", u.Rol.Id_Rol);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica_user", u.Baja_Logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica_empleado", u.Empleado.Baja_logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario_admin", admin.ID_Usuario);

                HelperDB.ObtenerInstancia().updatear_db("SP_Insertar_UsuarioEmpleado");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool BuscarDniUsuario(long dni)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@DNI", dni);
            HelperDB.ObtenerInstancia().LeerDB("SP_BuscarUsuarioDNI");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool BuscarAliasUsuario(string alias)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Alias", alias);
            HelperDB.ObtenerInstancia().LeerDB("SP_BuscarUsuarioAlias");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool BuscarUsuario(int id)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", id);
            HelperDB.ObtenerInstancia().LeerDB("SP_Buscar_usuario");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool ModificarUsuario(Usuarios u, Usuarios admin)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_empleado", u.Empleado.Id_Empleado);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario", u.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@direccion", u.Empleado.Direccion);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@telefono", u.Empleado.Telefono);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@alias", u.Alias);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@contraseña", encrypt.Encriptar(u.Contraseña));
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_rol", u.Rol.Id_Rol);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica_usuario", u.Baja_Logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@baja_logica_empleado", u.Empleado.Baja_logica);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id_usuario_admin", admin.ID_Usuario);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@nombre", u.Empleado.Nombre);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@apellido", u.Empleado.Apellido);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@dni", u.Empleado.DNI);
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@fecha_nac", u.Empleado.FechaNacimiento);

                HelperDB.ObtenerInstancia().updatear_db("SP_Actualizar_UsuarioEmpleado");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuarios> ObtenerUsuarios(int a)
        {
            List<Usuarios> lUsuarios = new List<Usuarios>();
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@condicion", a);
            HelperDB.ObtenerInstancia().LeerDB("SP_Obtener_usuarios");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            while (HelperDB.ObtenerInstancia().Dr.Read())
            {
                Usuarios usuario = new Usuarios();
                Empleado e = new Empleado();
                Roles r = new Roles();
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(0))
                {
                    e.Id_Empleado = HelperDB.ObtenerInstancia().Dr.GetInt32(0);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(1))
                {
                    usuario.ID_Usuario = HelperDB.ObtenerInstancia().Dr.GetInt32(1);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(2))
                {
                    e.DNI = HelperDB.ObtenerInstancia().Dr.GetInt64(2);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(3))
                {
                    e.Nombre = HelperDB.ObtenerInstancia().Dr.GetString(3);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(4))
                {
                    e.Apellido = HelperDB.ObtenerInstancia().Dr.GetString(4);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(5))
                {
                    e.Direccion = HelperDB.ObtenerInstancia().Dr.GetString(5);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(6))
                {
                    e.FechaNacimiento = HelperDB.ObtenerInstancia().Dr.GetDateTime(6);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(7))
                {
                    e.Telefono = HelperDB.ObtenerInstancia().Dr.GetInt64(7);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(8))
                {
                    e.Baja_logica = HelperDB.ObtenerInstancia().Dr.GetInt32(8);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(9))
                {
                    usuario.Alias = HelperDB.ObtenerInstancia().Dr.GetString(9);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(10))
                {
                    usuario.Contraseña = encrypt.Desencriptar(HelperDB.ObtenerInstancia().Dr.GetString(10));
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(11))
                {
                    r.Id_Rol = HelperDB.ObtenerInstancia().Dr.GetInt32(11);
                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(12))
                {
                    usuario.Baja_Logica = HelperDB.ObtenerInstancia().Dr.GetInt32(12);

                }
                if (!HelperDB.ObtenerInstancia().Dr.IsDBNull(13))
                {
                    r.Rol= HelperDB.ObtenerInstancia().Dr.GetString(13);

                }

                usuario.Empleado = e;
                usuario.Rol = r;
                lUsuarios.Add(usuario);
            }
            HelperDB.ObtenerInstancia().close();
            return lUsuarios;
        }

        public bool buscarId(int id, string alias)
        {
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@id", id);
            HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@alias", alias);
            HelperDB.ObtenerInstancia().LeerDB("SP_BuscarUsuarioID");
            HelperDB.ObtenerInstancia().Command.Parameters.Clear();

            if (HelperDB.ObtenerInstancia().Dr.Read())
            {
                HelperDB.ObtenerInstancia().close();
                return true;

            }
            HelperDB.ObtenerInstancia().close();
            return false;
        }

        public bool BloquearUsuario(string Alias)
        {
            try
            {
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                HelperDB.ObtenerInstancia().Command.Parameters.AddWithValue("@Alias", Alias);
                HelperDB.ObtenerInstancia().updatear_db("SP_BajarAlias");
                HelperDB.ObtenerInstancia().Command.Parameters.Clear();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
