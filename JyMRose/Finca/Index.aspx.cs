using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

namespace JyMRose.Finca
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                listar();
        }

        public void listar() 
        {
            FincaDal finca = new FincaDal();
            gvFinca.DataSource = finca.listar();
            gvFinca.DataBind();
        }

        protected void linkbtnBorrar_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldNombre");
            FincaDal finca = new FincaDal();
            finca.eliminar(hd.Value);
            listar();
        }

        protected void linkbtnEditar_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            HiddenField hd = (HiddenField)lb.FindControl("HiddenFieldNombre");
        }
    }
}