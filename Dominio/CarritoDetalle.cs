﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CarritoDetalle
    {
        public int Id { get; set; }
        public CarritoCabecera CarritoCabecera { get; set; }
        public Producto Producto { get; set; }
        public Promos Promos { get; set; }
        public int Cantidad { get; set; }
    }
}
