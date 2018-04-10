using System;
using System.Linq;
using System.Collections.Generic;

namespace Zoo
{
    // LESSON THINGY
    // extension:
    public static class ListExtensions
    {
        public static int NumberOfAnimalsOfType<T, Tcheck>(this IList<T> list)
        {
            return list.OfType<Tcheck>().Count();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // The zoo now is only a list of animals which have no cages of whatever. Every Animal can interact with any other. 
            // This is probably not going to work out well...



            List<Animal> AnimalsInZoo = new List<Animal>();


            // Herbivores
            Bunny Bella = new Bunny("Bella", 4, 2, Animal.ESex.female, 0);
            AnimalsInZoo.Add(Bella);
            Zebra Zali = new Zebra("Zali", 4, 400, Animal.ESex.female, 0);
            AnimalsInZoo.Add(Zali);
            // Carnivores

            Tiger Timmy = new Tiger("Timmy", 4, 400, Animal.ESex.male, 0.7f, 0);
            AnimalsInZoo.Add(Timmy);




            List<FoodItem> AvailableFood = new List<FoodItem>();

            Grass StartingGrass = new Grass(150);

            AvailableFood.Add(StartingGrass);

            /*
              There is a list of all available food in the zoo which every iteration is supplied with grass.
              If a herbivore is killed, its meat gets added to the foodlist. The attacking carnivore will eat untill full and leave the rest.
              
              
              List<FoodItem> AvailableFood = new List<FoodItem();
             
             
              while(not all herbivores are dead)
              {
              flavour text about how all animals go about their day and therefore get hungry
              herbivore can just eat grass and be all happy about it.
              
              
              
              Carnivores cannot and have to find food.
              When a carnivore gets hungry, it will kill and eat a herbivore.
              
              At the end of day, reduce the AmountOfEnergy by the DailyEnergyConsumption. IF AmountOfEnergy gets lower than twice??
              the DailyEnergyConsumption, the animal gets hungry and will look for food.
              If they hit 0, they die. 
              

            List<Animal> HungryAnimals = Animals.Where(a => a.isHungry).ToList();
            Foreach( IHerbivore herbivore in HungryAnimals)
            {
            if (AvailableFood.Contains(Grass)
            {
                herbivore.eat(grass)
                }
            
            Foreach (ICarnivore in HungryAnimals)
            {
            if (AvailableFood.Contains(Meat)
                {   
                Carnivore.eat(meat)
                }
                else
                {
                Carnivore.kill(prey)
                Carnivore.eat(meat)
                }



              Foreach(Animal a in Zoo)
               {
               a.AmountOfEnergy -= DailyEnergyConsumption;
               
               if(a.AmountOfEnergy <= 0)
               {
                    a.Die();
               }else if(a.AmountOfEnergy <= DailyEnergyConsumption)
               {
                   a.IsHungry = true;
                  }else if(a.AmountOfEnergy > DailyEnergyConsumption)
               {
                   a.IsHungy = false;
              }
              
              Console.Readkey in between to make it readable.
              
              
              carnivore.kill(IHerbivore prey)
              {
              prey.Die();
              Meat justkilled = new Meat(prey.FoodValue)
              AvailableFood.add(justkilled)
              
              }
              AvailableMeat = AvailableFood.OfType<Meat>();

              While(carnivore.AmountOfEnergy <= MaxAmountOfEnery)
              {
              
                carnivore.eat(AvailableMeat.First())         
              
                if carnivore.AmountOfEnergy > carnivore.MaxAmountOfEnergy
                {
                AmountOfEnergy = MaxAmountOfEnergy;
              }
              
             */



            // LESSON THINGY
            // extensions:
            AnimalsInZoo.NumberOfAnimalsOfType<Animal, Tiger>();

        }
    }
}
