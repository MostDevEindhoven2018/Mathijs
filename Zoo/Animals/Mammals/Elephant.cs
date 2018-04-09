using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : Mammal
    {
        public Elephant(string name, int numberOfLegs, float weight, ESex sex, int childrenInWomb) : 
            base(name, numberOfLegs, weight, sex, childrenInWomb )
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
            Weight = weight;

            Sound = "PAWAAAAAP";
            Sex = sex;
            ChildrenInWomb = childrenInWomb;

        }
        public override void Eat(Grass grass)
        {
            Console.WriteLine($"{Name} just ate and really enjoyed it.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {GetType().Name.ToString()} just made a sound. {Environment.NewLine}" +
                $"It sounded a bit like {Sound}. {Environment.NewLine}" +
                $"Nobody heard though, because nobody ever listens to {Name}.{Environment.NewLine}");
        }
    }
}
