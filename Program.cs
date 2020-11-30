using BuilderPatternExample.Contracts;
using BuilderPatternExample.Director;
using BuilderPatternExample.LoanTypes;
using System;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanWriter PaydayLoanWriter = new PayDayLoanWriter();
            LoanWriter LoCLoanWriter = new LineOfCreditLoanWriter();
            LoanDirector Director = new LoanDirector(PaydayLoanWriter);
            Director.WriteLoan();
            Loan PayDayLoan = Director.GetLoan();

            Console.WriteLine("Loan Type: {0}", PayDayLoan.GetName());
            Console.WriteLine("Loan Frequency: {0}", PayDayLoan.GetFrequency());
            Console.WriteLine("Loan Minimum Amount: ${0}", PayDayLoan.GetMinAmount());
            Console.WriteLine("Loan Maximum Amount: ${0}", PayDayLoan.GetMaxAmount());
            Console.WriteLine("Loan Interest Rate: {0}%", PayDayLoan.GetInterest());

            Director = new LoanDirector(LoCLoanWriter);
            Director.WriteLoan();

            Loan LoCLoan = Director.GetLoan();
            Console.WriteLine("");

            Console.WriteLine("Loan Type: {0}", LoCLoan.GetName());
            Console.WriteLine("Loan Frequency: {0}", LoCLoan.GetFrequency());
            Console.WriteLine("Loan Minimum Amount: ${0}", LoCLoan.GetMinAmount());
            Console.WriteLine("Loan Maximum Amount: ${0}", LoCLoan.GetMaxAmount());
            Console.WriteLine("Loan Interest Rate: {0}%", LoCLoan.GetInterest());

            Console.ReadKey();
        }
    }
}
