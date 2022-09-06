using Sep04;
using System.Security.Cryptography;

namespace Sep04Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m=new Manager();
            m.work();
            Employee emp=new Employee();
            emp.work();
            Clerk ck=new Clerk();
            ck.work();
            m.spot();
            Bank b = new Bank();
            Console.WriteLine("Enter deposit year,month,date");
            int Ye = Convert.ToInt32(Console.ReadLine());
            int Mo = Convert.ToInt32(Console.ReadLine());
            int kg = Convert.ToInt32(Console.ReadLine());
            DateTime mo = new DateTime(Ye, Mo, kg);
            b.Depositdate = mo;
            b.Noofdays();
            Console.WriteLine("Enter deposit");
            b.Deposit = Convert.ToInt32(Console.ReadLine());
            b.PrintBalance();
            b.CalculateInterest();
            Console.WriteLine("Enter Withdrwal");
            b.Withdraw = Convert.ToInt32(Console.ReadLine());
            b.PrintBalance();
            b.CalculateInterest();
            Savings s = new Savings();
            Console.WriteLine("Savings Dep amount");
            int mi = Convert.ToInt32(Console.ReadLine());
            s.Deposit= mi.deposit();
            Console.WriteLine("Withdraw amount from savings account");
            int im = Convert.ToInt32(Console.ReadLine());
            s.Withdraw = im.with();
            s.CalculateInterest();
            s.PrintBalance();
            Current c=new Current();
            Console.WriteLine("Current Dep amount");
            int pi = Convert.ToInt32(Console.ReadLine());
            c.Deposit = pi.deposit();
            Console.WriteLine("Current Withdraw amount");
            int ip = Convert.ToInt32(Console.ReadLine());
            c.Withdraw = ip.with();
            c.CalculateInterest();
            c.PrintBalance();

            Console.ReadLine();
        }
    }
}