using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Reptile : Animal
    {
        public Reptile(string name, float weight, ESex sex, string sound) : base(name, weight, sex)
        {
            NumberOfLegs = 6;
        }
    }
}
