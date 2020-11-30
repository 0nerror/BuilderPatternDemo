using BuilderPatternExample.Contracts;
using BuilderPatternExample.Enums;

namespace BuilderPatternExample.LoanTypes
{
    public class PayDayLoanWriter : LoanWriter
    {
        private Loan Loan;

        public PayDayLoanWriter()
        {
            this.Loan = new Loan();
        }

        public void WriteLoanFrequency()
        {
            Loan.SetFrequency(LoanFrequency.BiWeekly);
        }

        public void WriteLoanInterest()
        {
            Loan.SetInterest(18.6M);
        }

        public void WriteLoanName()
        {
            Loan.SetName("Payday");
        }

        public void WriteLoanMinAmount()
        {
            Loan.SetMinAmount(100.00M);
        }

        public void WriteLoanMaxAmount()
        {
            Loan.SetMaxAmount(1200.00M);
        }

        public Loan GetLoan()
        {
            return this.Loan;
        }
    }
}
