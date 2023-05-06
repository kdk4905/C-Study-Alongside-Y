using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AnimalShelter.Dog;

namespace AnimalShelter
{
    public class Pet
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petid, string name, string color, string gender)
        {
            PetId = petid;
            Name = name;
            Color = color;
            Gender = gender;
        }

        public virtual string MakeSound()
        {
             return "";
        }
    }
}
