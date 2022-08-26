using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        AnimalModel animal = new AnimalModel
        {
            Id = 1,
            Species = "Canino",
            Name = "Haik",
            Peso = 20.5f
        };
        [HttpGet]
        public AnimalModel Get() { return animal; }

        [HttpPost]
        public string Post(AnimalModel model)
        {
            AnimalRepository repo = new AnimalRepository();
            return repo.Create(model); 
           

        }

    }
}
