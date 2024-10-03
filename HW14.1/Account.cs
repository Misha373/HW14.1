using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14._1
{
    public class Account
    {
        private int money;
        private string name;


        public Account(int money, string name)
        {
            this.money = money > 0 ? money:0;
            this.name = name;
        }
        public int Deposit(int amount)
        {
            return money += amount;
        }
        public int Withdrawal(int amount)
        {
            return money -= amount;
        }
        public int Balance()
        {
            return money;
        }
        public string GetName()
        {
            return name;
        }
    }
}
