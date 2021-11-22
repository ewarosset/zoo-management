using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using zoo_management.Models.Database;
using zoo_management.Models.Requests;
using zoo_management.Models.Response;
using zoo_management.Repositories;

namespace zoo_management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalsRepo _animals;
        private readonly ILogger<AnimalController> _logger;

        public AnimalController(IAnimalsRepo animals)
        {
            _animals = animals;
        }

        // public AnimalController(ILogger<AnimalController> logger)
        // {
        //     _logger = logger;
        // }

        [HttpGet("")]
        public IEnumerable<Animal> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Animal
                {
                    Species = "animal",
                    Name = "name",
                    Sex = "sex",
                })
                .ToArray();
        }

        [HttpGet("view")]
        public IEnumerable<Animal> ViewAll()
        {
            return _animals.ViewAll();
        }

        [HttpGet("filter")]
        public ActionResult<ListResponse<AnimalResponse>.AnimalListResponse> Filter(
            [FromQuery] AnimalSearchRequest searchRequest)
        {
            var animals = _animals.Search(searchRequest);
            var animalsCount = _animals.Count(searchRequest);
            return ListResponse<AnimalResponse>.AnimalListResponse.Create(searchRequest, animals, animalsCount);

        }
    }
}