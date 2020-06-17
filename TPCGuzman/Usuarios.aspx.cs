using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCGuzman
{
    public partial class Usuarios : System.Web.UI.Page
    {
        public List<Persona> listaPersonas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PersonaNegocio personaNegocio = new PersonaNegocio();
                listaPersonas = personaNegocio.listar();

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}