using _EX__Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace _EX__Interfaces
{
    class BrickPayService: IPaymentService
    {
        public List<Installment> calculateInstallment(int installments, double value, DateTime date)
        {
            List<Installment> installmentList = new List<Installment>();
            for (int i = 1; i <= installments; i++)
            {
                double singleValue = value / installments;
                double instValue = singleValue + (singleValue * 0.01 * i);
                instValue += instValue * 0.02;
                DateTime newDate = date.AddMonths(i);
                Installment inst = new Installment(newDate, instValue);
                installmentList.Add(inst);
            }
            return installmentList;
        }
    }
}
