using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.model
{
    public abstract class Basemodel
    {
        [Key]
        public int Id { get; set; } 
    }
}
