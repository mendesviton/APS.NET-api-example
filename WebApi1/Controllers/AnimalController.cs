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
            
        };
        [HttpGet]
        public List<AnimalModel> Get() {
            AnimalRepository animalRepository = new AnimalRepository();
            return  animalRepository.GetAll();
        }

        [HttpPost]
        public string Post(AnimalModel model)
        {
            AnimalRepository repo = new AnimalRepository();
            return repo.Create(model); 
           

        }

    }
}
