using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.model
{
     public class AnimalModel : Basemodel
    {
        public string Species { get; set; }
        public string Name { get; set; }

        public float Peso { get; set; }
    }
}
