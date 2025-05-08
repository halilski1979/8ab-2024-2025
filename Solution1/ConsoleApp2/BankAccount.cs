using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class BankAccount
    {
		private int id;
        private double balance;

        public int ID
		{
			get { return id; }
			set { id = value; }
		}		

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public void Deposit(double amount)
		{
			Balance += amount;
		}

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
			return $"ID: {this.ID}, balance:{this.Balance}";
        }

    }
}
