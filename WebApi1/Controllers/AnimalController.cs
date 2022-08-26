using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        AnimalRepository animalRepository;
        public AnimalController()
        {
            animalRepository = new AnimalRepository();
        }

            

        AnimalModel animal = new AnimalModel
        {
            
        };
        [HttpGet]
        public List<AnimalModel> Get() {
            return  animalRepository.GetAll();
        }

        [HttpPost]
        public string Post(AnimalModel model)
        {
           
            return animalRepository.Create(model); 
           

        }

    }
}
