using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class LoginDal
    {
        JyMRoseEntities context = new JyMRoseEntities();
        public bool verificarUsuario(string usuario, string password) 
        {
            
                var usuarioLogin  = context.PR_UusuarioJyM.Where(u => u.UsuarioJyM==usuario && u.Acceso==password && u.EstadoUsuario==true ).ToList();
               
            if (usuarioLogin.Count > 0)
                {
               
                return true;
                }
                else {
                    return false;
                }
                

           
                     

        }
        public List<PR_UusuarioJyM> login(string usuario, string password)
        {
            var usuarioExiste = verificarUsuario(usuario, password);
            if (usuarioExiste==false) 
            {
                return null;
            }
             var usuarioLogin = context.PR_UusuarioJyM.Where(u => u.UsuarioJyM == usuario && u.Acceso == password && u.EstadoUsuario == true).ToList();
             return usuarioLogin;
        }
        
    }
}
