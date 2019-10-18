using System;
using System.Collections.Generic;

namespace Hungry_Ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int cal, bool spicy, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 1000, false, false),
                new Food("Wings", 650, true, false),
                new Food("Tacos", 250, true, false),
                new Food("Pho", 700, true, false),
                new Food("Burger", 1100, false, false),
                new Food("Fries", 550, false, false),
                new Food("Brownie", 700, false, true),
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            int randomNum = rand.Next(0, 7);
            return Menu[randomNum];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get 
            { 
                return calorieIntake > 1200;
            }
        }
        // build out the Eat method

        public void Eat(Food item)
        {
            if (IsFull != true)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"{item.Name} - Spicy: {item.IsSpicy}  Sweet: {item.IsSweet}");
                Eat(item);
            }
            else
            {
                System.Console.WriteLine("The ninja is full and can't eat any more.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet thisbuffet = new Buffet();
            Food newfood = thisbuffet.Serve();
            Ninja ninjaone = new Ninja();
            ninjaone.Eat(newfood);
            System.Console.WriteLine(ninjaone.FoodHistory);
        }
    }
}
