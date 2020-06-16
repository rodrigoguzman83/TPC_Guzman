using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CarritoCabecera
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public Persona persona { get; set; }
        public string tipoVenta { get; set; }
        public string formaPago { get; set; }
        public string estadoPedido { get; set; }
        public float Total { get; set; }
    }
}
