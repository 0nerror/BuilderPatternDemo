namespace BuilderPatternExample.Contracts
{
    public interface LoanWriter
    {
        public void WriteLoanName();
        public void WriteLoanFrequency();
        public void WriteLoanMinAmount();
        public void WriteLoanMaxAmount();
        public void WriteLoanInterest();
        public Loan GetLoan();
    }
}
