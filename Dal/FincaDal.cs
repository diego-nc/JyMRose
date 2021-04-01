using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public class FincaDal
    {
        JyMRoseEntities context = new JyMRoseEntities();
        public List<PR_Finca> listar()
        {
            
                var fincas = context.PR_Finca.ToList();
                return fincas;
           
        }

        public void eliminar(string nombre) 
        {
            var finca=context.PR_Finca.Single(f=>f.Nombre.Equals(nombre));
            context.PR_Finca.Remove(finca);
            context.SaveChanges();
        }
        public void nuevo(string nombre , string descripcion) 
        {
            PR_Finca finca = new PR_Finca();
            finca.Nombre = nombre;
            finca.Descripcion = descripcion;
            context.PR_Finca.Add(finca);
            context.SaveChanges();

        }
        public PR_Finca buscarFinca(string nombre) 
        {
            var finca = context.PR_Finca.Single(f => f.Nombre.Equals(nombre));
            return finca;
        }

        public void editar(int id,string nombre, string descripcion) 
        {
             var finca = context.PR_Finca.Single(f => f.Id.Equals(id));
            if (finca != null) {
                finca.Nombre = nombre;
                finca.Descripcion = descripcion;

                context.SaveChanges();
            }
            

        }

    }
}
