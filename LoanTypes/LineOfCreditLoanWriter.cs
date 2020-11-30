using BuilderPatternExample.Contracts;
using BuilderPatternExample.Enums;

namespace BuilderPatternExample.LoanTypes
{
    class LineOfCreditLoanWriter : LoanWriter
    {
        private Loan Loan;

        public LineOfCreditLoanWriter()
        {
            this.Loan = new Loan();
        }

        public Loan GetLoan()
        {
            return this.Loan;
        }

        public void WriteLoanFrequency()
        {
            Loan.SetFrequency(LoanFrequency.Monthly);
        }

        public void WriteLoanInterest()
        {
            Loan.SetInterest(10.8M);
        }

        public void WriteLoanMaxAmount()
        {
            Loan.SetMaxAmount(2500.00M);
        }

        public void WriteLoanMinAmount()
        {
            Loan.SetMinAmount(750.00M);
        }

        public void WriteLoanName()
        {
            Loan.SetName("LoC");
        }
    }
}
