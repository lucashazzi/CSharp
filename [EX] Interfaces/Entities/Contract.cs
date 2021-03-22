using System;
using System.Collections.Generic;
using System.Text;

namespace _EX__Interfaces.Entities
{
    class Contract
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public double InitialValue { get; set; }
        public int Installments { get; set; }
        public double TotalValue { get; set; }

        private IPaymentService _paymentService;

        public Contract()
        {

        }

        public Contract(string Number, double InitialValue, DateTime Date, IPaymentService paymentService, int Installments)
        {
            this.Number = Number;
            this.Date = Date;
            this.InitialValue = InitialValue;
            this.Installments = Installments;
            _paymentService = paymentService;
        }

        public List<Installment> calculateInstallments()
        {
            return _paymentService.calculateInstallment(Installments, InitialValue, Date);
        }



    }
}
