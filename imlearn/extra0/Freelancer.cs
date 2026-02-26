namespace extra0
{
    class Freelancer(decimal rate, int hours) : IPayable
    {
        public decimal Rate { get; init; } = rate;

        public int Hours { get; init; } = hours;
        public decimal GetPaymentAmount()
        {
            return Rate * Hours;
        }
    }
}
