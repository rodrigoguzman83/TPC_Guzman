using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoADatos;

namespace Negocio
{
    public class TipoUsuarioNegocio
    {
        public List<TipoUsuario> listar()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            TipoUsuario aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select id_tipo_usuario, descripcion from tipo_usuario");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new TipoUsuario();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Descripcion = datos.lector.GetString(1);

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }

        }
    }
}
