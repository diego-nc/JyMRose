using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using RestSharp;
using Newtonsoft.Json;

namespace JyMRose
{
    public partial class Api : System.Web.UI.Page
    {
        HttpClient http = new HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToken_Click(object sender, EventArgs e)
        {
            var email = "cserrano@solmovsa.com";
            var password = "secret123";
            string host = "https://broker.ecuasolmovsa.com";
       
            Datos datos = new Datos()
            {
                email = email,
                password=password
            };
            string json = JsonConvert.SerializeObject(datos);
            var  respuesta= postUser(host, json);
            lblToken.Text = respuesta.ToString();

        }
        public dynamic  postUser(string url, string json)
        {
            var endPoint = "/api/auth/login";
            var client = new RestClient(url+endPoint);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            dynamic datos = JsonConvert.DeserializeObject(response.Content);
            lblToken.Text = response.Content;
            return datos;
        }
        
    }
    public class Datos
    {
        public string email { get;set; }
        public string password { get; set; }
    }
}