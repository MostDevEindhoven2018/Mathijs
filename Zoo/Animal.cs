using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public float Weight { get; set; }
        public float AmountOfEnergy { get; set; }
        public float MaxAmountOfEnergy { get; set; }
        public float DailyEnergyConsumption { get; set; }
        public float StopEatingThreshold { get; set; }


        public float FoodValue
        {
            get
            {
                return Weight / 2;
            }
        }

        public ESex Sex { get; set; }
        public string Pronoun
        {
            get
            {
                if (Sex == ESex.male)
                {
                    return "him";
                }
                else if (Sex == ESex.female)
                {
                    return "her";
                }
                else
                {
                    return "its";
                }
            }
        }
        

        public bool IsHungry { get; set; }
        public bool IsAlive { get; set; } = true;

        public string Sound { get; set; }

        public Animal() { }

        public Animal(string name, float weight, ESex sex)
        {
            Name = name;
            Weight = weight;
            Sex = sex;
            
        }


        public abstract void MakeSound();

        public virtual void Die()
        {
            IsAlive = false;

        }

        public enum ESex
        {
            male,
            female
        }
    }
}
