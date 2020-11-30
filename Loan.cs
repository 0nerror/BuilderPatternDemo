using BuilderPatternExample.Contracts;
using BuilderPatternExample.Enums;

namespace BuilderPatternExample
{
    public class Loan : LoanContract
    {
        private string Name;
        private decimal Interest;
        private LoanFrequency Frequency;
        private decimal MinAmount;
        private decimal MaxAmount;

        public void SetFrequency(LoanFrequency frequency)
        {
            Frequency = frequency;
        }

        public LoanFrequency GetFrequency()
        {
            return Frequency;
        }

        public void SetInterest(decimal interest)
        {
            Interest = interest;
        }

        public decimal GetInterest()
        {
            return Interest;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetMinAmount(decimal minAmount)
        {
            MinAmount = minAmount;
        }

        public decimal GetMinAmount()
        {
            return MinAmount;
        }

        public void SetMaxAmount(decimal maxAmount)
        {
            MaxAmount = maxAmount;
        }

        public decimal GetMaxAmount()
        {
            return MaxAmount;
        }
    }
}
