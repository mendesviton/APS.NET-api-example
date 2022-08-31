using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.model
{
    public class UsuarioModel : Basemodel
    {
        public string email { get; set; }
        public string name { get; set; }

        [JsonIgnore]
        public string password { get; set; }
    }
}
