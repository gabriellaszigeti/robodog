using RoboDog.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Models
{
    public class DogStorage : IDogStorage
    {

        private readonly List<Dog> _dogs = new List<Dog>();

        public Dog AddDog(Dog dog)
        {
            var name = dog.Name;
            var age = dog.Age;
            var breed = Breed.Akita;
            var newDog = new Dog(name, age, breed);
            _dogs.Add(newDog);
            return newDog;
        }

        public Dog AddRandomDog()
        {
            DogCreator creator = new DogCreator();
            var dog = creator.CreateRandomDog();
            _dogs.Add(dog);
            return dog;
        }


        public IEnumerable<Dog> GetAllDogs()
        {
            return _dogs;
        }

        public Dog UpdateDogInfo(string name, int age, Breed breed) { 
 //            var result = (from x in _dogs where x.Name == name select x).First();
            var newDog = _dogs.FirstOrDefault(dog => dog.Name == name);
            newDog.Name = name;
            newDog.Age = age;
            newDog.Breed = breed;
            return newDog;


        }

    }
}