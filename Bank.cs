using System.Collections.Generic;

static class Bank
{
    private static List<Customer> customers = new();

    public static void CreateAccount(Customer customer, BankAccount account)
    {
        customers.Add(customer);
        customer.Accounts.Add(account);
    }

    public static void DeleteAccount(Customer customer, BankAccount account)
    {
        customer.Accounts.Remove(account);
    }

    public static void Transaction(BankAccount from, BankAccount to, decimal amount)
    {
        from.Withdraw(amount);
        to.Deposit(amount);
    }
}