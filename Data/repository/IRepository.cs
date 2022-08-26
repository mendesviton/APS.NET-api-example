using Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.repository
{
    public interface  IRepository<T> where T : Basemodel
    {
        string Create(T model);
        string Update(T model);
            
        string Delete(int id);

        List<T> GetAll();
        
        T GetById(int id);
    }
}
