using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

namespace JyMRose.Finca
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var nombre = Request.QueryString["nombre"];
                FincaDal finca = new FincaDal();
                var fincaEditar=finca.buscarFinca(nombre);
                lblId.Text=fincaEditar.Id.ToString();

                txtNombre.Text = fincaEditar.Nombre;
                txtDescripcion.Text = fincaEditar.Descripcion;
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(lblId.Text);
                var nombre = txtNombre.Text;
                var descripcion = txtDescripcion.Text;
                FincaDal finca = new FincaDal();
                finca.editar(id, nombre, descripcion);
                Response.Redirect("~/Finca/Index.aspx");

            }
            catch 
            {
                lblMensaje.Text = "No se pudo editar finca";
            }

        }
    }
}