using System.Collections.Generic;

class Customer
{
    public string Name { get; set; }
    public List<BankAccount> Accounts = new();
    public Customer(string name, BankAccount account = null) => Name = name;
}