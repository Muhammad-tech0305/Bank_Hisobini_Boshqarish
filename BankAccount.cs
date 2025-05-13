using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    private decimal Balance { get; set; }
    public BankAccount(string accountNumber, decimal balance = 0)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Pul miqdori 0 dan kichik bo'lishi mumkin emas!");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Hisobingizda yetarli pul mavjud emas!");
        }
        else
        {
            Console.WriteLine("Pul miqdori 0 dan kichik bo'lishi mumkin emas!");
        }
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}