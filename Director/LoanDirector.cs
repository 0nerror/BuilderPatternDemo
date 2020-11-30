using BuilderPatternExample.Contracts;

namespace BuilderPatternExample.Director
{
    public class LoanDirector
    {
        private LoanWriter LoanWriter;

        public LoanDirector(LoanWriter loanWriter)
        {
            LoanWriter = loanWriter;
        }

        public Loan GetLoan()
        {
            return this.LoanWriter.GetLoan();
        }

        public void WriteLoan()
        {
            LoanWriter.WriteLoanName();
            LoanWriter.WriteLoanInterest();
            LoanWriter.WriteLoanMinAmount();
            LoanWriter.WriteLoanMaxAmount();
            LoanWriter.WriteLoanFrequency();
        }
    }
}
