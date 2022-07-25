namespace interface_exercise.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double paymentFee = 0.02;
        private const double interest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * paymentFee;
        }

        public double Interest(double amount, int months)
        {
            return amount * interest * months;
        }
    }
}
