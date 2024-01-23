using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accout_DongVat_DAHINH
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

                account Tk1 = new checkingAccount(200);
                Tk1.Withdraw(10);
                Tk1.PrintBalance();
             
                account Tk2 = new savingaccount(300);
                Tk2.Withdraw(30);
                Tk2.PrintBalance();
                

                Console.ReadLine();
            }
        }
    }
   
