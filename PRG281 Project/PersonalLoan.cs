using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG281_Project
{
    internal class PersonalLoan:Loan
    {
        public PersonalLoan(int loanNumber, string lastName, string firstName, double amount, int term, double primeInterestRate)
            : base(loanNumber, lastName, firstName, amount, term, primeInterestRate)
        {
            InterestRate = (primeInterestRate + 2) / 100;// This line of code calculate the value of the
                                                         // intrest rate for the users choosing a personal loan
        }

    }
}
