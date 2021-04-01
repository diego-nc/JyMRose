using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal; 
namespace JyMRose
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarDatos();
        }
        public void mostrarDatos()
        {
            int idUsuario = (int)Session["idUsuario"];
             
            UsuarioDal usuarioInfo = new UsuarioDal();
            var datos = usuarioInfo.usuarioDatos(idUsuario);
            foreach (var usuario in datos) 
            {
                lblNombre.Text = usuario.Nombre;
                lblApellido.Text = usuario.Apellido;
            }
           


        }
    }
}