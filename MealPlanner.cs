using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment1
{
    public interface IMealPlan
    {
        string GetMeal();
    }

    // Vegetarian Meal Implementation
    public class VegetarianMeal : IMealPlan
    {
        public string GetMeal()
        {
            return "Vegetarian Salad";
        }
    }

    // Vegan Meal Implementation
    public class VeganMeal : IMealPlan
    {
        public string GetMeal()
        {
            return "Vegan Budhha Bowl";
        }
      
    }

    // Keto Meal Implementation
    public class KetoMeal : IMealPlan
    {
        public string GetMeal()
        {
            return "Keto Grilled Chicken";
        }
    }

    // High-Protein Meal Implementation
    public class HighProteinMeal : IMealPlan
    {
        public string GetMeal()
        {
            return "High Protien steak";
        } 
    }

    // Generic Meal Class
    public class Meal<T> where T : IMealPlan, new()
    {
        public T MealPlan { get; private set; }

        public Meal()
        {
            MealPlan = new T();
        }

        public void DisplayMeal()
        {
            Console.WriteLine($"Meal: {MealPlan.GetMeal()}");
        }
    }

    // Meal Plan Factory
    public static class MealPlanFactory
    {
        public static Meal<T> CreateMeal<T>() where T : IMealPlan, new()
        {
            return new Meal<T>();
        }
    }
}
