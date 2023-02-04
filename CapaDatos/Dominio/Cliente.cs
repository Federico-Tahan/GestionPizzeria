﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Datos;

namespace CapaDatos.Dominio
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Tipo_Cliente TipoCliente { get; set; }
        public string Direccion { get; set; }
        public long Telefono { get; set; }
        public Socio socio { get; set; }
        public int Baja_logica { get; set; }

    }
}