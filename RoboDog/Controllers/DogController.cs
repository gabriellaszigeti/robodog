using Microsoft.AspNetCore.Mvc;
using RoboDog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DogController : Controller
    {


        private readonly IDogStorage _dogStorage;

        public DogController(IDogStorage _dogStorage)
        {
            this._dogStorage = _dogStorage;
        }


        //Controller has a GET endpoint for returning all the stored dogs.

        [HttpGet]
        public IEnumerable<Dog> GetDogs()
        {
            return _dogStorage.GetAllDogs();
        }


        //Controller has a GET endpoint for returning a randomly created dog.

        [HttpGet("Random")]
        public Dog GetRandomDog()
        {
            var randomDog = _dogStorage.AddRandomDog();
            return randomDog;
        }


        //(dog's data is kept in the Request Body) !!!

        [HttpPost("NewDog")]
        public ActionResult AddNewDog([FromBody] Dog dog)
        {
            _dogStorage.AddDog(dog);
            return Ok(dog);
        }

    }
}