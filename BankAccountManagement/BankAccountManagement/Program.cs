using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Welcome to our Bank ?");
            Console.WriteLine("===========================================");

            do
            {
                Program.Query();
                Console.WriteLine("===========================================");

                Console.WriteLine(" Chose 'y' for another Account:");
                ConsoleKeyInfo jk = Console.ReadKey();
                ch = jk.KeyChar;
            } while (ch == 'y');
            Console.ReadKey();  
        }
            public static void Query()
        {
            char chose;
            char ch;
            double number,number2;
            BankAccount account = new BankAccount();

            
            
            do {
                Console.WriteLine("Chose d for Deposit.\n      w for Withdraw.\n      q for Quary_Balance");
                ConsoleKeyInfo k = Console.ReadKey();
                chose = k.KeyChar;
                switch (chose)
            {
                case 'd':
                    Console.WriteLine("\nPlease Enter the money :");
                   string input = Console.ReadLine();
                        if (double.TryParse(input, out number))
                        {
                            account.Deposit(number);
                            Console.WriteLine("Your Balance ={0}", account.GetBalance());
                            Console.WriteLine("===========================================");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid number.");
                            Console.WriteLine("===========================================");
                        }
                       
                    break;
                case 'w':
                    Console.WriteLine("\nPlease Enter the number :");
                    string input2 = Console.ReadLine();
                        if (double.TryParse(input2, out number2))
                        {
                            account.Withdraw(number2);
                            Console.WriteLine("Your Balance ={0}", account.GetBalance());
                            Console.WriteLine("===========================================");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid number.");
                            Console.WriteLine("===========================================");
                        }
                        
                        break;
                case 'q':
                        Console.WriteLine("Your Balance ={0}", account.GetBalance());
                        Console.WriteLine("===========================================");
                        break;
                default:
                    Console.WriteLine("\nSorry You Don't Chose Any Item, \n Thank You , Baye!");
                    break;
            }
                Console.WriteLine(" Chose 'y' for another operation:");
                ConsoleKeyInfo key = Console.ReadKey();
                ch = key.KeyChar;

            } while (ch == 'y');
        }
        
    }
    class BankAccount
    {
        private double _balance;
       public BankAccount()
        {  _balance = 0; }
        public void Deposit(double amount)
        {
            if (amount > 0)
                _balance += amount;
            else
                Console.WriteLine("Invalid amount!");
        }
        public double Withdraw(double amount)

        {
            if (amount > 0 && _balance >= amount)
                return  _balance -= amount;
            else
                return _balance;
        }
        //public void PrintBalance()
        //{
        //    Console.WriteLine("===========================================");

        //    Console.WriteLine("Your Balance = {0} $",_balance);

        //    Console.WriteLine("===========================================");
        //}
        public double GetBalance()
        {
            return _balance;
        }
    }

}
