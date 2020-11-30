using BuilderPatternExample.Enums;

namespace BuilderPatternExample.Contracts
{
    public interface LoanContract
    {
        public void SetName(string name);
        public void SetMinAmount(decimal minAmount);
        public void SetMaxAmount(decimal maxAmount);
        public void SetFrequency(LoanFrequency frequency);
        public void SetInterest(decimal interest);

    }
}
