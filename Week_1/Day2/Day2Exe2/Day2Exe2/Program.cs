using System.Xml.Linq;

namespace Day2Exe2
{
    internal class Program
    {
        abstract class BankAccount
        {
            public int AccountNumber;
            public int Balance;
           public BankAccount(int  accountNumber, int balance)
            {
                this.AccountNumber = accountNumber;
                this.Balance = balance;
            }
            public abstract void Deposit(int amount);

            public abstract void Withdraw(int amount);
            
        }
         class SavingsAccount :BankAccount 
        {
            public int InterestRate;
            public SavingsAccount(int accountNumber, int balance,int interestRate):base( accountNumber, balance)
            {
                this.InterestRate = interestRate;
            }
            public override void Deposit(int amount)
            {
                Balance += (Balance * amount);
                Console.WriteLine("balance: " + Balance);
            }
            public override void Withdraw(int amount)
            {
                Balance -= (Balance * amount);
                Console.WriteLine("balance: " + Balance);
            }
        }
        class CheckingAccount: BankAccount
        {
            public int OverdraftLimit;
            public CheckingAccount(int accountNumber, int balance, int overdraftLimit):base( accountNumber, balance)
            {
                this.OverdraftLimit = overdraftLimit;
            }
            public override void Deposit(int amount)
            {
                if (amount < OverdraftLimit)
                {
                    OverdraftLimit += amount;
                    Console.WriteLine("overdraftLimit:" + OverdraftLimit);
                }
                else
                {
                    Balance += amount;  
                    Console.WriteLine("balance: "+ Balance);
                }
            }
            public override void Withdraw(int amount)
            {
                if (amount < OverdraftLimit)
                {
                    OverdraftLimit -= amount;
                    Console.WriteLine("overdraftLimit:" + OverdraftLimit);
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine("balance: " + Balance);
                }
              
            }
        }
        static void Main(string[] args)
        {
            BankAccount bankaccount = new CheckingAccount( 01, 50000,2000);
            bankaccount.Deposit(5000);
            bankaccount.Withdraw(100);
            BankAccount account = new SavingsAccount(01, 20222, 15);
            bankaccount.Deposit(5000);
            bankaccount.Withdraw(100);

        }
    }
}