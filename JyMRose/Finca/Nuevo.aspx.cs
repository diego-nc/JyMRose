using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

namespace JyMRose.Finca
{
    public partial class Nuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text;
                var descripcion = txtDescripcion.Text;
                FincaDal finca = new FincaDal();
                finca.nuevo(nombre, descripcion);
                Response.Redirect("~/Finca/Index.aspx");
            }
            catch
            {
                lblMensaje.Text = "No se pudo agregar  nueva finca";
            }
        }
    }
}