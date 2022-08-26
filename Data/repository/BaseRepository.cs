using Data.ContextWebApi;
using Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.repository
{
    public class BaseRepository<T> : IRepository<T>  where T : Basemodel
    {
        List<T> entityList;
        public  BaseRepository()
        {
            entityList = new List<T>();
        }

        public virtual List<T> GetAll()
        {
            List<T> listAnimal = new List<T>();
            //esse bloco vai fazer com que feche as conexoes
            using (WebApiContext webApiContext = new WebApiContext())
            {

                listAnimal = webApiContext.Set<T>().ToList();
            }

            return listAnimal;
        }
        public virtual string Create(T model)
        {
            using (WebApiContext webApiContext = new WebApiContext())
            {
                webApiContext.Set<T>().Add(model);


                webApiContext.SaveChanges();
            }
            return "criado";
        }
      

        public virtual string Delete(int id)
        {
            return "deletado";  
        }

       

        public virtual T GetById(int id)
        {
            T model = null;
            //esse bloco vai fazer com que feche as conexoes
            using (WebApiContext webApiContext = new WebApiContext())
            {

                model = webApiContext.Set<T>().Find(id);
            }

            return model;
        }

        public virtual  string Update(T model)
        {
            return "alterado";
        }
    }
    
}
