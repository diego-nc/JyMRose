using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace JyMRose
{

    public partial class WebService : System.Web.UI.Page
    {
        ServicioWeb.CatalogSoapClient ws = new ServicioWeb.CatalogSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            var cedula = txtCedula.Text;
            consumirWS(cedula);
            
           
        }
        public void consumirWS(string cedula) 
        {
            var user = ws.GetUserInformation(cedula);
            gvUser.DataSource = user;
            gvUser.DataBind();
        }
    }
}