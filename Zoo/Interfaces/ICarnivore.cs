using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zoo
{
    public interface ICarnivore 
    {
        bool Eat(List<FoodItem> availableFood);
    }
}
