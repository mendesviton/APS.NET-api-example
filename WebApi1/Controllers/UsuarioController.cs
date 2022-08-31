using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.DTO;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : GenericController<UsuarioModel, UsuarioRepository>
    {
        public UsuarioController() : base(new UsuarioRepository())
        {

            

        }

       
    }
}
