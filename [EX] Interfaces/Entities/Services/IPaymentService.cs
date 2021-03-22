using System;
using System.Collections.Generic;

namespace _EX__Interfaces.Entities
{
    interface IPaymentService
    {
        public List<Installment> calculateInstallment(int installments, double value, DateTime date);
    }
}
