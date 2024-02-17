using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Models
{
    public interface IDogStorage
    {
        public Dog AddDog(Dog dog);
        public Dog AddRandomDog();
        public IEnumerable<Dog> GetAllDogs();
        public Dog UpdateDogInfo(string name, int age, Breed breed);
    }
}