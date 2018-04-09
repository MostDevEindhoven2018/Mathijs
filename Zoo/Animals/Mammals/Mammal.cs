using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    abstract class Mammal : Animal
    {
        public int ChildrenInWomb { get; set; }

        public Mammal(string name, int numberOfLegs, float weight, ESex sex, int childrenInWomb) : base(name, weight, sex)
        {
            NumberOfLegs = numberOfLegs;
            ChildrenInWomb = childrenInWomb;
        }
    }
}
