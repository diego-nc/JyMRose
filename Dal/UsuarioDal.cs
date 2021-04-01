using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public class UsuarioDal
    {
        JyMRoseEntities context = new JyMRoseEntities();
        public List<PR_UusuarioJyM> usuarioDatos(int id)
        {


            var usuarioLogin = context.PR_UusuarioJyM.Where(u => u.Id == id).ToList();

                return usuarioLogin;

            


        }

    }
}
