using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Dog : Pet
    {
        public enum DogBreed 
        {
            Mixed,
            Bulldog,
            Jindo,
            YorkShire
        }

        public DogBreed Breed;

        public Dog(int petid, string name, string color, string gender, DogBreed breed)
            : base(petid, name, color, gender)
        {
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
