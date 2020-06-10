using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class CarritoCabecera
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public Cliente cliente { get; set; }
        public string tipoVenta { get; set; }
        public string formaPago { get; set; }
        public float Total { get; set; }
    }
}
