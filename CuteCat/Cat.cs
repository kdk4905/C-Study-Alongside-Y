﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteCat
{
    public class Cat
    {
        public string Name;
        public int Age;
        private int Happiness;

        public Cat(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public void Play() 
        {
            Happiness = Happiness + 10;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public void GetBored() 
        {
            Happiness = Happiness - 10;

            if (Happiness < 0)
                Happiness = 0;
        }

        public void Eat() 
        {
            Happiness = Happiness + 20;

            if (Happiness > 100) 
            {
                Happiness = 100;
            }
        }

        public string Express() 
        {
            string message = "";

            if (Happiness >= 80)
                message = "I'm verry happy";
            else if (Happiness >= 60)
                message = "I'm happy";
            else if (Happiness >= 40)
                message = "I'm soso";
            else if (Happiness >= 20)
                message = "I'm gloomy";
            else
                message = "I'm sad";
            return this.Name + message;
        }
    }
}
