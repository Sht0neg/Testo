using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string UserName { get; private set; }
        public float Balance { get; private set; }

        public BankAccount(string userName, float initialBalance = 0)
        {
            if (initialBalance < 0)
                Balance = 0;
            else
            {
                UserName = userName;
                Balance = initialBalance;
            }
        }

        public void Deposit(float amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(float amount)
        {
            if (amount > 0)
            {

                if (Balance - amount >= 0)
                {
                    Balance -= amount;
                }
            }
        }

        public void Transfer(BankAccount recipient, float amount)
        {
            if (this.Balance >= amount)
            {
                Withdraw(amount);
                recipient.Deposit(amount);
            }
        }
    }
}
