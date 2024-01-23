using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Accout_DongVat_DAHINH
{
    internal class savingaccount:account
    {
       
            protected double interesRate = 0.8;

            public savingaccount() :base() 
            {

            }
            public savingaccount (double _banlance) : base(_banlance) { }
            public double InteresRate
            {
                set { interesRate = value; }
                get { return interesRate; }
            }
            public override bool Withdraw(double amount)
            {
                if (amount > 0 && amount < Balance)
            {
                    Balance = Balance - (amount + amount * interesRate);
                    return true;
                }
                return false;

            }
            public override bool Deposit(double amount)
            {
                if ( amount > 0&& amount<Balance)
                {
                       Balance = Balance + (amount + amount * interesRate);
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


