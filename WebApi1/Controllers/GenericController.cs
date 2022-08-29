using Data.model;
using Data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : Basemodel
    {
        BaseRepository<T> genericRepository;
        public GenericController()
        {
           this.genericRepository = new BaseRepository<T>();
        }



        
        [HttpGet]
        public List<T> Get()
        {
            return genericRepository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return genericRepository.GetById(id);
        }

        [HttpPost]
        public string Post(T model)
        {

            return genericRepository.Create(model);


        }
        [HttpPut]
        public string Put(T model)
        {

            return genericRepository.Update(model);


        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return genericRepository.Delete(id);
        }

    }
}
