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
        public BaseRepository()
        {
            entityList = new List<T>();
        }
        public string Create(T model)
        {
            return "Criado";
        }

        public string Delete(int id)
        {
            return "deletado";  
        }

        public List<T> GetAll()
        {
            return entityList;
        }

        public T GetById(int id)
        {
            T entity = null;
            return entity;
        }

        public string Update(T model)
        {
            return "alterado";
        }
    }
    
}
