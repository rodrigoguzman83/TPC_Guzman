using System;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Celular { get; set; }

        public string Usuario { get; set; }
        public string Clave { get; set; }

        public TipoUsuario tipoUsuario { get; set; }
        public int Estado { get; set; }
    }
}
