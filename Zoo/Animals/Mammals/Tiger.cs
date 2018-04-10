using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    class Tiger : Mammal, ICarnivore
    {
        public Tiger(string name, int numberOfLegs, float weight, ESex sex, float stopEatingThreshold, int childrenInWomb) :
           base(name, numberOfLegs, weight, sex, childrenInWomb)
        {
            Name = name;
            Weight = weight;
            NumberOfLegs = numberOfLegs;
            StopEatingThreshold = stopEatingThreshold;

            Sound = "RwaawaR";

            Sex = sex;
            ChildrenInWomb = childrenInWomb;
        }

        public bool Eat(List<FoodItem> availableFood)
        {
            List<Meat> availableMeat = availableFood.Where(x => x.GetType().Name == "Meat").Cast<Meat>().ToList();
            if (availableMeat.Count() > 0)
            {
                // there is meat available. Let the carnivore eat. 
                // check if the current fooditem is sufficient to fill the carnivore
                if (availableMeat.First().FoodValue > (MaxAmountOfEnergy - AmountOfEnergy))
                {
                    // If so, eat as much as possible, setting amount of energy to max, and subtracting the foodValue from the Item.
                    AmountOfEnergy = MaxAmountOfEnergy;
                    availableMeat.First().FoodValue -= (MaxAmountOfEnergy - AmountOfEnergy);

                    Console.WriteLine($"{Name} the {GetType().Name.ToString()} just ate some meat and really enjoyed it. {Environment.NewLine}" +
                                     $"It filled {Pronoun} up completely. Let's sleep...{Environment.NewLine}");
                    return true;
                }
                else
                {
                    // If not, add the foodValue to energy, and completely remove this piece of meat from the list. 
                    AmountOfEnergy += availableMeat.First().FoodValue;
                    availableFood.Remove(availableMeat.First());
                    // decide if we want to eat more. If we are below the threshold, continue eating. if not, leave it at this.

                    if (AmountOfEnergy <= StopEatingThreshold * MaxAmountOfEnergy)
                    {
                        Console.WriteLine($"{Name} the {GetType().Name.ToString()} just ate some meat and really enjoyed it. {Environment.NewLine}" +
                                     $"It didn't fill {Pronoun} up completely, though. Lets try to find some more...{Environment.NewLine}");
                        Eat(availableFood);
                    }
                    else
                    {
                        Console.WriteLine($"{Name} the {GetType().Name.ToString()} just ate some meat and really enjoyed it. {Environment.NewLine}" +
                                     $"It didn't fill {Pronoun} up completely, but it was sufficient for today. Let's sleep... {Environment.NewLine}");
                    }
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Uh oh! There is no more meat left in the zoo. It might be time to go hunt for something");
                return false;
            }
        }


        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {GetType().Name.ToString()} just made a sound. {Environment.NewLine}" +
                $"It sounded a bit like {Sound}. {Environment.NewLine}" +
                $"Nobody heard though, because nobody ever listens to {Name}.{Environment.NewLine}");
        }
    }
}
