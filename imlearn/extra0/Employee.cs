namespace extra0
{
    class Employee(decimal salary) : IPayable
    {
        public decimal Salary { get; init; } = salary;
        
        public decimal GetPaymentAmount()
        {
            return Salary;
        }
    }
}
