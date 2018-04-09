using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class TrapdoorSpider : Arachnid
    {
        

        public TrapdoorSpider(string name, float weight, ESex sex) : base(name, weight, sex)
        {
            Sound = "...";
        }

        public TrapdoorSpider() { }

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
