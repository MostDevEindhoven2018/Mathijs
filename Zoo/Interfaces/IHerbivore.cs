using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public interface IHerbivore
    {
        bool Eat(List<FoodItem> availableFood);
    }
}
