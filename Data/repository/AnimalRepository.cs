using Data.ContextWebApi;
using Data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.repository
{
    public class AnimalRepository :BaseRepository<AnimalModel>
    {
        public override List<AnimalModel> GetAll()
        {
            List<AnimalModel> listAnimal = new List<AnimalModel>();
            WebApiContext webApiContext = new WebApiContext();
            listAnimal = webApiContext.Animal.ToList();
            return listAnimal;
        }

    }
}
