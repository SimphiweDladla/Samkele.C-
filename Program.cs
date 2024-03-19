namespace Samkele.C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("1. Enter Recipe");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear Recipe");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option: ");
                string input = Console.ReadLine();


                if (input == "1")
                {
                    recipe.EnterRecipe();
                }
                else if (input == "2")
                {
                    recipe.DisplayRecipe();
                }
                else if (input == "3")
                {
                    recipe.ScaleRecipe();
                }
                else if (input == "4")
                {
                    recipe.ResetRecipe();
                }
                else if (input == "5")
                {
                    recipe.ClearRecipe();
                }
                else if (input == "6")
                {
                    break;
                }
            }
        }
           
                }
            }
         
    

