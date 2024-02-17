using RoboDog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Service
{
    public class DogCreator
    {

        private string[] _dogNames = { "Bilbo", "Arwen", "Gollumn", "Eowen", "Nazgul", "Gimli", "Legolas" };
        public const int MinAge = 1;
        public const int MaxAge = 20;

        public Dog CreateRandomDog()
        {
            var enumValues = Enum.GetValues(typeof(Breed));
            var random = new Random();
            return new Dog
            {
                Age = random.Next(MinAge, MaxAge),
                Name = _dogNames[random.Next(_dogNames.Length)],
                Breed = (Breed)enumValues.GetValue(random.Next(enumValues.Length))
            };
        }

        public
    }
}