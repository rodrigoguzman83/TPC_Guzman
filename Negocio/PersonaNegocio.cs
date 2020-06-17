using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using AccesoADatos;

namespace Negocio
{
    public class PersonaNegocio
    {
        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();
            Persona aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select a.id_persona,a.nombre,a.apellido,a.celular,a.mail,a.usuario,a.id_tipo_usuario,b.descripcion from personas a inner join tipo_usuario b on b.id_tipo_usuario = a.id_tipo_usuario where a.estado = 1");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Persona();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Nombre = datos.lector.GetString(1);
                    aux.Apellido = datos.lector.GetString(2);
                    aux.Celular = datos.lector.GetString(3);
                    aux.Mail = datos.lector.GetString(4);
                    aux.Usuario = datos.lector.GetString(5);

                    aux.tipoUsuario = new TipoUsuario ();
                    aux.tipoUsuario.Id = datos.lector.GetInt32(6);
                    aux.tipoUsuario.Descripcion = datos.lector.GetString(7);

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
