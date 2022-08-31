using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.DTO;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesController : ControllerBase
    {
        [HttpPost("Logon")]
        public UsuarioModel Logon(UsuarioDto UsuarioDto)
        {
            UsuarioRepository repo = new UsuarioRepository(); 
            UsuarioModel user = repo.Logon(UsuarioDto.email, UsuarioDto.password);
            return user;
        }
    }
}
