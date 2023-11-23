using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_exercise_interfaces.Entities;

namespace csharp_exercise_interfaces.Services
{
    internal class ContractService : IContractService
    {
        private readonly IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int installments)
        {
            var installmentValue = contract.Value / installments;
            for (int i = 1; i <= installments; i++)
            {
                var installmentDate = contract.Date.AddMonths(i);
                var interest = _paymentService.Interest(installmentValue, i);
                var paymentFee = _paymentService.PaymentFee(installmentValue + interest);
                var installment = new Installment(installmentDate, installmentValue + interest + paymentFee);
                contract.Installments.Add(installment);
            }
        }
    }
}
