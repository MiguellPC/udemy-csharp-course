using interface_exercise.Entities;

namespace interface_exercise.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this._onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double interest = baseQuota +  _onlinePaymentService.Interest(baseQuota, i);
                double paymentFee = interest + _onlinePaymentService.PaymentFee(interest);
                contract.AddInstallment(new Installment(contract.Date.AddMonths(i), paymentFee));
            }
        }
    }
}
