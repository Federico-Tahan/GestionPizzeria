﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Dominio
{
    public class Bitacora
    {
        public Empleado empleado { get; set; }
        public List<DetalleBitacora> DetalleBit { get; set; }
    }
}