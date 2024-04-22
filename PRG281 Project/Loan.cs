using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    public abstract class Loan: LoanConstants
    {
        public int LoanNumber { get; }

        public string CustomerLastName { get; }
        public string CustomerFirstName { get; }
        public double loanAmount { get; }
        public double InterestRate { get; set; }
        public int Term { get; set; }

        public int ShortTerm => 1;
        public int MediumTerm => 3;
        public int LongTerm => 5;
        public string CompanyName => "Digital Banking";
        public double MaxLoanAmount => 100000;
        public Loan(int loanNumber, string lastName, string firstName, double amount, int term, double InterestRate)
        {
            LoanNumber = loanNumber;
            CustomerLastName = lastName;
            CustomerFirstName = firstName;

            

            bool RightAmount = false;
            
            double inputTest;
            while (RightAmount == false)// This while loop is used to validat the value of the loan amount to make sure the the value 
                                        // that was entered by the user is not larger than R100 000
            {

                if ((amount >= 1) && (amount <= MaxLoanAmount))
                {
                    RightAmount = true;
                    loanAmount = amount;
                }
                else
                {
                    bool isAString = true;

                    while (isAString == true)
                    {
                        //Try again: The loan amount is not between the limit of 1 and 100 000.
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("  Try again: ");
                        Console.ResetColor();
                        Console.Write("The loan amount is not ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("between");
                        Console.ResetColor();
                        Console.Write(" the limit of ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("1");
                        Console.ResetColor();
                        Console.Write(" and ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("100 000");
                        Console.ResetColor();
                        Console.WriteLine(".");

                        Console.Write("  Enter ");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write("loan amount");
                        Console.ResetColor();
                        Console.Write(" : ");

                         

                        if (double.TryParse(Console.ReadLine(), out inputTest))
                        {
                            amount = inputTest;
                            isAString = false;
                        }
                    }
                   
                    
                    
                }

            }


            Term = term;// this validates the value of the term that has been enterd to check that if the usser inputs a insufficient value
                        // , the term will be set to a default value.
            if (term != ShortTerm && term != MediumTerm && term != LongTerm)
            {
                Term = ShortTerm; 
            }
        }   
        
       
        public override string ToString()// This function is used to display the data of the arrays
        {
            return $"  Loan Number: {LoanNumber}\n" +
                   $"  Customer Name: {CustomerFirstName} {CustomerLastName}\n" +
                   $"  Loan Amount: {loanAmount:C}\n" +
                   $"  Loan Fee: {(loanAmount * InterestRate):C}\n" +
                   $"  Total Amount Owed at due date: {(loanAmount + (loanAmount * InterestRate)):C}\n" +
                   $"  Interest Rate: {InterestRate:P}\n" +
                   $"  Term: {Term} years\n" +
                   $"  Company Name: {CompanyName}";
        }
       
    }
}
