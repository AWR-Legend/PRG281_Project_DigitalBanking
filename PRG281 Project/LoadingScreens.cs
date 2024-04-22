using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PRG281_Project
{
    internal class LoadingScreens
    {
        //This method creates a loading screen between each loan creation
        //This loading screen makes for a smoother transition between entering new loans
        //This method also tells the user after 5 iterations that all the data will be displayed
        public void loadingImputs(int iterationIndex)
        {

            //This is a method that displays a loading animation 3 times
            loading();


            //After the main program has created 5 loans, a different set of text should be displayed
            //This will show how many loans should still be created before the next display
            if (iterationIndex==4)
            {
                //After 3 iterations, the console will display green text to show that the loading is complete
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOAN SUCCESSFULLY CREATED");
                Thread.Sleep(500);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("      DISPLAYING CREATED LOANS");
                Thread.Sleep(1000);
            }
            else
            {
                //This plays an animation that displays three loading dots
                //This method also displays how many loans are left before they are displayed
                creatingNewLoans(iterationIndex);
            }

            
            Console.ResetColor();
        }



        //This is a public method that displays a loading animation 3 times
        public void loading()
        {
            //The loading animation will will iterate 3 times
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOADING");

                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOADING  .");

                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOADING  .  .");

                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOADING  .  .  .");
            }
        }



        //This method plays an animations where three dots appear
        //This method also displays how many loans are left before they are displayed
        public void creatingNewLoans(int iterationIndex)
        {
            string creatingLoanLoading = "      CREATING NEW LOAN";

            //After 3 iterations, the console will display green text to show that the loading is complete
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      LOAN SUCCESSFULLY CREATED");
            Thread.Sleep(500);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(string.Format("      {0} ", (4 - iterationIndex)));
            Console.ResetColor();
            Console.WriteLine("LOANS LEFT TILL NEXT LOAN DISPLAY");
            Console.WriteLine();
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(creatingLoanLoading);

            //This loop will iterate three times to display three dots           
            for (int i = 0; i < 3; i++)
            {
                //A dot gets added every iteration
                creatingLoanLoading = creatingLoanLoading + "  .";
                
                Thread.Sleep(300);
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      LOAN SUCCESSFULLY CREATED");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(string.Format("      {0} ", (4 - iterationIndex)));
                Console.ResetColor();
                Console.WriteLine("LOANS LEFT TILL NEXT LOAN DISPLAY");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(creatingLoanLoading);
            }
            Thread.Sleep(200);

        }
    }
}
