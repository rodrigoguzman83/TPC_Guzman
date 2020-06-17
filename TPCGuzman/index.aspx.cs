﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPCGuzman
{
    public partial class index : System.Web.UI.Page
    {
        public List<TipoUsuario> listaTipoUsuarios { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TipoUsuarioNegocio negocio = new TipoUsuarioNegocio();
                listaTipoUsuarios = negocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}