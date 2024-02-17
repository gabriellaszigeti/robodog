using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDog.Models
{
    public class Dog
    {
        public Dog(string name, int age, Breed breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        public Dog()
        {

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
    }
}