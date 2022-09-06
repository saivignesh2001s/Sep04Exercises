using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sep04
{
    public abstract class Person
    {
        public abstract void work();
        public void spot()
        {
            Console.WriteLine("fav destination is Chennai");
        }
    }
    public class Employee : Person
    {
        public override void work()
        {
            Console.WriteLine("I am employee");
        }
    }
    public class Manager : Person
    {
        public override void work()
        {
            Console.WriteLine("I am manager");
        }

    }
    public class Clerk : Person
    {
        public override void work()
        {
            Console.WriteLine("I am clerk");
        }
    }
    interface Ibank
    {
        void CalculateInterest();
        void PrintBalance();
    }
    public class Bank : Ibank
    {
        private int initialbalance = 500;
        private int deposit;
        public int Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        private int withdrawal;
        public int Withdraw
        {
            get { return withdrawal; }
            set
            {
                if (total() < 500)
                {
                    withdrawal = 0;
                }
                {
                    withdrawal = value;
                }
            }
        }
        public int total()
        {
            int Total = 0;
            Total = deposit + initialbalance - withdrawal;
            return Total;
        }

        private DateTime depositdate;
        public DateTime Depositdate
        {
            get { return depositdate; }
            set { depositdate = value; }
        }
        public void Noofdays()
        {
            TimeSpan t = DateTime.Now - depositdate;
            Console.WriteLine($"Number of days{t.TotalDays}");
        }

        public void CalculateInterest()
        {
            int s = total();
            Console.WriteLine("Enter interest rate");
            int m = Convert.ToInt32(Console.ReadLine());
            float Interest = (s * m) / 100;
            Console.WriteLine($"Interest rate per year is {Interest}");
        }

        public void PrintBalance()
        {
            int n = total();
            Console.WriteLine($"Balance is {n}");
        }
    }
    public class Savings : Bank, Ibank
    {

        public void CalculateInterest()
        {
            int m = base.total();
            float Interest = (4 * m) / 100;
            Console.WriteLine($"Savings account Interest is {Interest}");
        }

        public void PrintBalance()
        {
            int m = base.total();
            float Interest = (4 * m) / 100;
            float ni = m + Interest;
            Console.WriteLine($"Balance is {ni}");
        }
    }
    public class Current : Bank, Ibank
    {

        public void CalculateInterest()
        {
            int m = base.total();
            float Interest = (2 * m) / 100;
            Console.WriteLine($"Current account Interest is {Interest}");
        }

        public void PrintBalance()
        {
            int m = base.total();
            float Interest = (2 * m) / 100;
            float ni = m + Interest;
            Console.WriteLine($"Balance is {ni}");
        }
    }
    public static class extension{
        
        public static int deposit(this int i)
        {
            return i;
        }
        public static int with(this int i)
        {
            return i;
        }
        }
}
