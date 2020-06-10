using System;
using System.Collections.Generic;
using System.Text;

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
