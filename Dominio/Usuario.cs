﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public Cliente cliente { get; set; }
        public Empleado empleado { get; set; }
        public string clave { get; set; }
    }
}
