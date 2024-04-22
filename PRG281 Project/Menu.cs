using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    //These are the different "Buttons" that can be selected
    //Uses these values to navigate between pages
    public enum menuOptions 
    {
        Business, Personal, Close, Yes, No
    }

    class Menus
    {
        //This is just a method to quickly display the navigation methods at the top of each menu screen
        //This is mainly done since the color switching of text can be hard to read or understand at a glance
        //This also takes up a lot of space to repeatedly ad it in each menu block
        public void navigationLine()
        {
            Console.Write("\n  Please use ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("UP Arrow");
            Console.ResetColor();
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DOWN Arrow");
            Console.ResetColor();
            Console.Write(" to navigate, press ");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("ENTER");
            Console.ResetColor();
            Console.WriteLine(" to select an option\n");
        }


        //This is the first menu the user will see
        //This menu comes directly after the main page
        public string oneMenu()
        {
            //Tis is an index that simulates the users selected button
            //It starts at zero, since that is the first buttons value
            int SelectingIndex = 0;


            //This is the defualt state of the menu
            //This is also the first verient of the menu the user will see
            navigationLine();
            Console.WriteLine("  Please choose an option\n");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("> Personal Loan              <");
            Console.ResetColor();
            Console.WriteLine("    Business Loan               ");
            Console.WriteLine("    Close Program               ");

            //This gets the user's keyboard button imput
            ConsoleKeyInfo pressed = Console.ReadKey(true);

            //If the user did not press enter yet the following code will execute
            while (pressed.Key != ConsoleKey.Enter)
            {
                //This tells the program which menu varient to display (button is being hovered over) 
                //This increases and decreases the index, when arrow keys are clicked
                if ((pressed.Key == ConsoleKey.UpArrow) && (SelectingIndex != 0))
                {
                    SelectingIndex--;
                }
                else if ((pressed.Key == ConsoleKey.DownArrow) && (SelectingIndex != 2))
                {
                    SelectingIndex++;
                }

                Console.Clear();

                //This tells the program which menu varient to display (button is being hovered over) 
                //This depends on the index previously mentioned
                switch (SelectingIndex)
                {
                    case 0:
                        navigationLine();
                        Console.WriteLine("  Please choose an option\n");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> Personal Loan              <");
                        Console.ResetColor();
                        Console.WriteLine("    Business Loan               ");
                        Console.WriteLine("    Close Program               ");
                        break;
                    case 1:
                        navigationLine();
                        Console.WriteLine("  Please choose an option\n");
                        Console.WriteLine("    Personal Loan               ");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> Business Loan              <");
                        Console.ResetColor();
                        Console.WriteLine("    Close Program               ");
                        break;
                    case 2:
                        navigationLine();
                        Console.WriteLine("  Please choose an option\n");
                        Console.WriteLine("    Personal Loan               ");
                        Console.WriteLine("    Business Loan               ");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> Close Program              <");
                        Console.ResetColor();

                        break;

                }

                //This gets the user's keyboard button imput for next loop
                pressed = Console.ReadKey(true);

            }

            //Returns the enum menu values as strrings
            //Used to determine which menu option was clicked
            // string menuopt = "";
            Console.Clear();
            switch (SelectingIndex)
            {
                case 0:
                    return Convert.ToString(menuOptions.Personal);

                case 1:
                    return Convert.ToString(menuOptions.Business);

                case 2:
                    return Convert.ToString(menuOptions.Close);

            }


            return "";

        }

        //This menu asks the user if they want to close the program
        //This menu pops up after the user clicks on the "Close Program Button"
        public string menuYesNoCloseProgram()
        {
            //Tis is an index that simulates the users selected button
            //It starts at zero, since that is the first buttons value
            int SelectingIndex = 0;

            Console.Clear();

            //This is the defualt state of the menu
            //This is also the first verient of the menu the user will see
            navigationLine();
            Console.WriteLine("  Are you sure you want to close the program\n");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("> YES <");
            Console.ResetColor();
            Console.WriteLine("    NO   ");

            //This gets the user's keyboard button imput
            ConsoleKeyInfo pressed = Console.ReadKey(true);

            //If the user did not press enter yet the following code will execute
            while (pressed.Key != ConsoleKey.Enter)
            {
                //This tells the program which menu varient to display (button is being hovered over) 
                //This increases and decreases the index, when arrow keys are clicked
                if ((pressed.Key == ConsoleKey.UpArrow) && (SelectingIndex != 0))
                {
                    SelectingIndex--;
                }
                else if ((pressed.Key == ConsoleKey.DownArrow) && (SelectingIndex != 1))
                {
                    SelectingIndex++;
                }

                Console.Clear();

                //This tells the program which menu varient to display (button is being hovered over) 
                //This depends on the index previously mentioned
                switch (SelectingIndex)
                {
                    case 0:
                        navigationLine();
                        Console.WriteLine("  Are you sure you want to close the program\n");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> YES <");
                        Console.ResetColor();
                        Console.WriteLine("    NO   ");
                        break;
                    case 1:
                        navigationLine();
                        Console.WriteLine("  Are you sure you want to close the program\n");
                        Console.WriteLine("    YES  ");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> NO  <");
                        Console.ResetColor();
                        break;
                }

                //This gets the user's keyboard button imput for next loop
                pressed = Console.ReadKey(true);

            }

            Console.Clear();

            //Returns the enum menu values as strrings
            //Used to determine which menu option was clicked
            switch (SelectingIndex)
            {
                case 0:
                    return Convert.ToString(menuOptions.Yes);

                case 1:
                    return Convert.ToString(menuOptions.No);

            }
            return "";
        }

        //This menu displayes at the end of the program
        //This menu askes the user if the want to repeat the experience
        //If no is selected, the program will close
        public string menuYesNoBackToMenu()
        {
            //Tis is an index that simulates the users selected button
            //It starts at zero, since that is the first buttons value
            int SelectingIndex = 0;

            Console.Clear();

            //This is the defualt state of the menu
            //This is also the first verient of the menu the user will see
            navigationLine();
            Console.WriteLine("  Would you like to go back to the main page\n");
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("> YES <");
            Console.ResetColor();
            Console.WriteLine("    NO   ");

            //This gets the user's keyboard button imput
            ConsoleKeyInfo pressed = Console.ReadKey(true);

            //If the user did not press enter yet the following code will execute
            while (pressed.Key != ConsoleKey.Enter)
            {
                //This tells the program which menu varient to display (button is being hovered over) 
                //This increases and decreases the index, when arrow keys are clicked
                if ((pressed.Key == ConsoleKey.UpArrow) && (SelectingIndex != 0))
                {
                    SelectingIndex--;
                }
                else if ((pressed.Key == ConsoleKey.DownArrow) && (SelectingIndex != 1))
                {
                    SelectingIndex++;
                }

                Console.Clear();

                //This tells the program which menu varient to display (button is being hovered over) 
                //This depends on the index previously mentioned
                switch (SelectingIndex)
                {
                    case 0:
                        navigationLine();
                        Console.WriteLine("  Would you like to go back to the main page\n");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> YES <");
                        Console.ResetColor();
                        Console.WriteLine("    NO   ");
                        break;
                    case 1:
                        navigationLine();
                        Console.WriteLine("  Would you like to go back to the main page\n");                       
                        Console.WriteLine("    YES  ");
                        Console.Write("  ");
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("> NO  <");
                        Console.ResetColor();
                        break;
                }

                //This gets the user's keyboard button imput for next loop
                pressed = Console.ReadKey(true);

            }


            Console.Clear();

            //Returns the enum menu values as strrings
            //Used to determine which menu option was clicked
            switch (SelectingIndex)
            {
                case 0:
                    return Convert.ToString(menuOptions.Yes);

                case 1:
                    return Convert.ToString(menuOptions.No);

            }
            return "";
        }



    }

}
