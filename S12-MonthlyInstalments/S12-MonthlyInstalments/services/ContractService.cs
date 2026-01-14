using S12_MonthlyInstalments.entities;

namespace S12_MonthlyInstalments.services;

public class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int month)
    {
        double basicQuota = contract.TotalValue;
        
        for (int i = 1; i <= month; i++)
        {
            DateTime date = contract.Date.AddMonths(i);
            double updateQuota = basicQuota + _onlinePaymentService.Interests(basicQuota, i);
            double fullQuota = updateQuota +  _onlinePaymentService.PaymentFee(updateQuota);
            contract.AddInstallment(new Installment(date, fullQuota));
        }
    }
}