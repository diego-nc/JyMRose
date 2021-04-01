using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;


namespace JyMRose
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();

        }
        public void ingresar() 
        {
            var usuario = txtUsuario.Text;
            var password = txtPassword.Text;

            LoginDal ingreso = new LoginDal();
            var logueo = ingreso.login(usuario, password);
            if (logueo != null)
            {
                Session["idUsuario"] = logueo[0].Id;

                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write("<script language=javascript>alert('Usuario o Password incorrecto');</script>");
                Response.Redirect("~/Login.aspx");
            }
        }
        
    }
}