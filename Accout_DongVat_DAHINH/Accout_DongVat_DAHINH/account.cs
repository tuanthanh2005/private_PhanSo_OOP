using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accout_DongVat_DAHINH
{
    internal class account
    {


            protected double _balance;


            public account() : base()
            {

            }

            public account(double _balance)
            {
                this._balance = _balance;
            }
            public double Balance
            {
                set { _balance = value; }
                get { return _balance; }
            }
            public virtual bool Withdraw(double amount)
            {
                return false;
            }
            public virtual bool Deposit(double amount)
            {
                return false;
            }


            public virtual void PrintBalance()
            {
                Console.WriteLine(" Chua có du lieu");
            }

        }

    }


