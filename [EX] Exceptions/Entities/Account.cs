using Exceptions.Entities.Exceptions;
using System.Globalization;

namespace Exceptions.Entities
{
    class Account
    {
        private int _number { get; set; }
        private string _holder { get; set; }
        private double _balance { get; set; }
        private double _withdrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value >= 0)
                    _number = value;
                else
                    throw new DomainException("The account number is invalid.");
            }
        }

        public double Balance
        {
            get => _balance;
            set
            {
                if (value >= 0)
                    _balance = value;
                else
                    throw new DomainException("The balance value cannot be negative.");
            }
        }

        public string Holder
        {
            get => _holder;
            set
            {
                if (value.Length > 0)
                    _holder = value;
                else
                    throw new DomainException("The holder name can't be empty.");
            }
        }

        public double WithdrawLimit
        {
            get => _withdrawLimit;
            set
            {
                if(value >= 0)
                {
                    _withdrawLimit = value;
                }
                else
                {
                    throw new DomainException("The withdraw limit can't be negative.");
                }
                
            }
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > _withdrawLimit)
                throw new DomainException("The amount inserted is superior to the withdraw limit.");
            else if (amount > _balance)
                throw new DomainException($"You don't have enough balance (${_balance.ToString("F2", CultureInfo.InvariantCulture)}) to withdraw.");
            _balance -= amount;
        }
    }
}
