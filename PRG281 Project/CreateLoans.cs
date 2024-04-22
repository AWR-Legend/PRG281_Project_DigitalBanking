using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

namespace PRG281_Project
{
    public class CreateLoans
    {
        public bool DisplayLoan()
        {
            Menus menus = new Menus();

            double primeInterestRate;
            
            // this do while loop tests the input given by user to make sure that the user has given the correct input for the prime intrest rate
            do
            {
                Console.WriteLine();
                Console.Write("  Enter the ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("current prime interest rate");
                Console.ResetColor();
                Console.Write(" : ");
            } while ((!double.TryParse(Console.ReadLine(), out primeInterestRate))||(primeInterestRate<=0));
            Console.Clear();

            LoadingScreens loadingScreen = new LoadingScreens();

            Loan[] loans = new Loan[5];


            // this forloop is used to populate the arrays for the loans
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                char loanType='C';
                switch (menus.oneMenu())// this switch case is used to determine which case will be executed based on the users input
                {
                    case "Business":
                        Console.WriteLine();
                        Console.ForegroundColor= ConsoleColor.DarkGreen;
                        Console.WriteLine("      Bussiness Loan \n");
                        Console.ResetColor();
                        loanType = 'B';
                        
                        break;
                    case "Personal":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("      Personal Loan \n");
                        Console.ResetColor();
                        loanType = 'P';
                        
                        break;
                    case "Close":
                        return  true;
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"  Loan {i + 1}:");
                Console.ResetColor();

               
                int loanNumber = (i + 1);

                
                string firstName;
                do // this do while loop tests the input given by user to make sure that the
                   // user has given the correct input for the users first name which should only contain letters
                {
                    Console.Write("    Enter customer (use only letters) ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("first name");
                    Console.ResetColor();
                    Console.Write(" : ");
                    firstName = Console.ReadLine();
                }
                while (!OnlyLetters(firstName));

                         

                string lastName;
                do// this do while loop tests the input given by user to make sure that the
                  // user has given the correct input for the users last name which should only contain letters
                {
                    Console.Write("    Enter customer (use only letters) ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("last name");
                    Console.ResetColor();
                    Console.Write(" : ");
                    lastName = Console.ReadLine();
                }
                while (!OnlyLetters(lastName));


                
               

                double loanAmount;
                // this do while loop tests the input given by user to make sure that the
                // user has given the correct input for the loan amount which should only contain numbers
                do
                {
                    Console.Write("    Enter ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("loan amount");
                    Console.ResetColor();
                    Console.Write(" : "); 
                } while (!double.TryParse(Console.ReadLine(), out loanAmount) );


                int loanTerm;
                // this do while loop tests the input given by user to make sure that the
                // user has given the correct input for the loan term which should only contain numbers
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("  The prime intrest rate must be greater than 0 and may not contain letters or symbols");
                    Console.Write("      Enter loan term (");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("1");
                    Console.ResetColor();
                    Console.Write(" for Short-Term, ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("3");
                    Console.ResetColor();
                    Console.Write(" for Medium-Term, ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("5");
                    Console.ResetColor();
                    Console.Write(" for Long-Term) : ");
                } while (!int.TryParse(Console.ReadLine(), out loanTerm) || loanTerm <= 0);


                // These if statements determines to which class the input data is sent.
                if (loanType == 'B')
                {
                    loans[i] = new BusinessLoan(loanNumber, lastName, firstName, loanAmount, loanTerm, primeInterestRate);
                }
                else if (loanType == 'P')
                {
                    loans[i] = new PersonalLoan(loanNumber, lastName, firstName, loanAmount, loanTerm, primeInterestRate);
                }

                //loadingDelegate loadingMethod = loadingScreen.loadingImputs;

                //This method will display a loading screen to make the transition between pages a little smoother
                Thread loading = new Thread(()=>loadingScreen.loadingImputs(i));
                loading.Start();
                loading.Join();
            }
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n    Loans created:\n");
            Console.ResetColor();
            foreach (Loan loan in loans)// This foreach statement displays the arrays of the loans
            {
                Thread.Sleep(500);
                Console.WriteLine(loan);
                Console.WriteLine();
            }
            Console.ReadLine();
            return false;
            

        }
        static bool OnlyLetters(string input)// this function is used to check if the users input only contains letters
        {
           
            return Regex.IsMatch(input, @"^[A-Za-z]+$");
        }
    }
}
