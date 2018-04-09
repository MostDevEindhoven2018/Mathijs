using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Fish : Animal
    {
        public Fish(string name, float weight, ESex sex) : base(name, weight, sex)
        {
            NumberOfLegs = 0;
        }
    }
}
