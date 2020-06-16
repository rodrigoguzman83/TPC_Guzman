using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Promos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public string ImagenURL { get; set; }
        public int Estado { get; set; }

    }
}
