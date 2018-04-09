using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Tuna : Fish
    {
        public Tuna(string name, float weight, ESex sex) : base(name, weight, sex)
        {
            Name = name;
            Weight = weight;

            Sex = sex;

            Sound = "Hi there! You probably didnt expect a tuna to speak English now did you";
        }

        public override void Eat()
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
