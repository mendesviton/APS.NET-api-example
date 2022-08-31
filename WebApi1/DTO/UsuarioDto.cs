using Data.model;
using System.Text.Json.Serialization;

namespace WebApi1.DTO
{
    public class UsuarioDto
    {
        public string email { get; set; }
        
        public string password { get; set; }

    }
}
