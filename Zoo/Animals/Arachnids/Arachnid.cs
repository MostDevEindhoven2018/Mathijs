using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Arachnid : Animal
    {
        public Arachnid(string name, float weight, ESex sex) : base(name, weight, sex)
        {
            NumberOfLegs = 8;
        }
        public Arachnid() { }
    }
}
