using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samkele.C_
{
    class Recipe
    {
        private object originalQuantities;
        private object originalUnits;

        public List<Ingredients> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredients>();
            Steps = new List<string>();
        }

        public void EnterRecipe()
        {
            Console.Write("Enter number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Ingredients ingredient = new Ingredients();

                Console.Write("Enter ingredient name: ");
                ingredient.Name = Console.ReadLine();

                Console.Write("Enter quantity: ");
                ingredient.Quantity = double.Parse(Console.ReadLine());

                Console.Write("Enter unit: ");
                ingredient.Unit = Console.ReadLine();

                Ingredients.Add(ingredient);
            }

            Console.Write("Enter number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write("Enter step description: ");
                string step = Console.ReadLine();
                Steps.Add(step);

            }



                    // i want to Handle fractional quantity
               /* }
                if (scale == 0.5 && Ingredients.Quantity % 1 == 0)
                {
                    Ingredients.Quantity /= 2;
                }
                else
                {
                    Ingredients.Quantity *= scale;
                }*/

            }
            }
        }


        // Here is how you could prompt the user to enter a scale factor in the ScaleRecipe() method
        private static void ScaleRecipe1()
        {
            double scaleFactor;

            while (true)
            {
                Console.Write("Enter scale factor (0.5, 2 or 3): ");
                if (double.TryParse(Console.ReadLine(), out scaleFactor))
                {
                    if (scaleFactor == 0.5 || scaleFactor == 2 || scaleFactor == 3)
                    {
                        break;
                    }
                }
                Console.WriteLine("Invalid input. Please enter 0.5, 2 or 3.");
            }

        }
        public void ResetRecipe()
        {
            // Assume originalQuantities dictionary is populated  
            // when ingredients are first added

            foreach (Ingredients ingredient in Ingredients)
            {
              //  ingredient.Quantity = originalQuantities[ingredient.Name];
            }

            // Optionally clear scaled units
            foreach (Ingredients ingredient in Ingredients)
            {
              //  ingredient.Unit = originalUnits[ingredient.Name];
            }
        }
        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();

            // Also reset any other data fields

           /* originalQuantities.Clear();
            originalUnits.Clear();*/
        }
    }
}

