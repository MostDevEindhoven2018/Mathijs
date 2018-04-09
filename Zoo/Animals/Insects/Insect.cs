using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Insect : Animal
    {
        public Insect(string name, float weight, ESex sex, string sound) : base(name, weight, sex)
        {
            NumberOfLegs = 6;
        }
    }
}
