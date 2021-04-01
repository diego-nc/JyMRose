using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;

namespace JyMRose
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        public void salir()
        {
            Session["idUsuario"] = null;
           
            Response.Redirect("~/Login.aspx");
        }

    }
}