using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Cliente:Persona
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string EntreCalle1 { get; set; }
        public string EntreCalle2 { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
    }
}
