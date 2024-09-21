using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingReview.src.OopPrinciples
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            ;
        }

        public BankAccount(decimal amount) {
            Deposit(amount);
        }

        public decimal GetBalance() {
                return balance;
        }
            
        public void SetBalance(decimal amount) {
            if (balance < 0) {
                throw new ArgumentException("Balance must be positive");
            }

            this.balance = amount;
        }

        public void Deposit(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Deposit amount must be positive");
            }

            this.balance += amount;
        }

        public void Withdraw(decimal amount) {
            if (amount <= 0) {
                throw new ArgumentException("Withdrawal amount must be positive");
            }
            if (amount > balance) {
                throw new ArgumentException("Insufficient Funds");
            }

            this.balance -= amount;
        }
    }
}