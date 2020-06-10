using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Estado { get; set; }
    }
}
