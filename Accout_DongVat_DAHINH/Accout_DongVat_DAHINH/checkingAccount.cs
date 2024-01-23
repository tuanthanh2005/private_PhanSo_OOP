using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accout_DongVat_DAHINH
{
    internal class checkingAccount:account
    {
        public checkingAccount()
        {

        }
        public checkingAccount(double balance) : base(balance) { }

        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount < Balance)
            {
                Balance =Balance- amount;
                return true;
            }
            return false;

        }
        public override bool Deposit(double amount)
        {
            if (amount > 0 && amount < Balance)
            {
                Balance = Balance + amount;
                return true;
            }
            return false;

        }
        public override void PrintBalance()
        {
            Console.WriteLine("Xuat so du{0}", Balance);
        }
    }
}

    

