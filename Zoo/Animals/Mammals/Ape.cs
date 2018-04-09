using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Ape : Mammal
    {
        public Ape(string name, int numberOfLegs, float weight, ESex sex, int childrenInWomb) :
            base(name, numberOfLegs, weight, sex, childrenInWomb)
        {
            Name = name;
            Weight = weight;

            Sex = sex;
            ChildrenInWomb = childrenInWomb;

            Sound = "oeh haha ha oeh";
        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} just ate and really enjoyed it.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {GetType().Name.ToString()} just made a sound. {Environment.NewLine}" +
                $"It sounded a bit like {Sound}. {Environment.NewLine}" +
                $"Nobody heard though, because nobody ever listens to {Name}. {Environment.NewLine}");
        }
    }
}
