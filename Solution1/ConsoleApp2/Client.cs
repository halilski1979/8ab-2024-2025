using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Client
    {
        Dictionary<int,BankAccount> accounts= new Dictionary<int,BankAccount>();

        public void Create(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Accounts already exist!!!");
            }
            else
            {
                BankAccount account= new BankAccount();
                account.ID = id;
                accounts.Add(id, account);
            }
        }

        public void Deposit(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Accounts MOT  exist!!!");
            }
            else
            {
                BankAccount account = accounts.FirstOrDefault(x=>x.Key==id).Value;
                account.Deposit(amount);
            }
        }

        public void Withdraw(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Accounts MOT  exist!!!");
            }
            else
            {
                BankAccount account = accounts.FirstOrDefault(x => x.Key == id).Value;
                if (account.Balance < amount)
                {
                    Console.WriteLine("Nqma tolkova pari");
                }
                else
                {
                    account.Withdraw(amount);
                }
            }
        }

        public void Print(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Accounts MOT  exist!!!");
            }
            else
            {               
                BankAccount account=accounts.FirstOrDefault(x=>x.Key==id).Value;
                Console.WriteLine(account.ToString());               
            }
        }
    }
}
