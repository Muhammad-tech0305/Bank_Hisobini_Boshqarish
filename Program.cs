using System;

Console.WriteLine(" \t Assalomu a'laykum!  ");
Console.Write("Ismingizni kiriting: ");
string name = Console.ReadLine();
Customer customer = new Customer(name);

while (true)
{
    Console.WriteLine(" \t <<< BankApp >>> ");
    Console.WriteLine("1. Hisob yaratish" + "\n2. Hisob raqamlarimni ko'rish" + "\n3. Pul o'tkazish" + "\n4. Hisob balansini ko'rish" + "\n5. Depozit qo'yish" + "\n6. Chiqish");
    Console.Write("Bo'limni tanlang: ");

    try
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Hisob raqam kiriting: ");
                string accountNumber = Console.ReadLine();
                BankAccount account = new BankAccount(accountNumber);
                Bank.CreateAccount(customer, account);
                Console.WriteLine("Hisob raqam yaratildi!");
                break;

            case 2:
                Console.WriteLine("Hisob raqamlar: ");
                if (customer.Accounts == null)
                {
                    Console.WriteLine("Hisob raqamlar mavjud emas!");
                    break;
                }
                foreach (BankAccount acc in customer.Accounts)
                {
                    Console.WriteLine($"'{acc.AccountNumber}', balansi: acc.GetBalance()");
                }
                break;

            case 3:
                Console.Write("Pul yechiladigan hisob raqamingizni kiriting: ");
                string fromAccountNumber = Console.ReadLine();
                BankAccount fromAccount = null;
                foreach (BankAccount acc in customer.Accounts)
                {
                    if (acc.AccountNumber == fromAccountNumber)
                    {
                        fromAccount = acc;
                        break;
                    }
                }
                if (fromAccount == null)
                {
                    Console.WriteLine("Bunday hisob raqam mavjud emas!");
                    break;
                }
                Console.Write("Pul o'tkaziladigan hisob raqamingizni kiriting: ");
                string toAccountNumber = Console.ReadLine();
                BankAccount toAccount = null;
                foreach (BankAccount acc in customer.Accounts)
                {
                    if (acc.AccountNumber == toAccountNumber)
                    {
                        toAccount = acc;
                        break;
                    }
                }
                if (toAccount == null)
                {
                    Console.WriteLine("Bunday hisob raqamli hisob mavjud emas!");
                    break;
                }
                Console.Write("Yechish summasini kiriting: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                Bank.Transaction(fromAccount, toAccount, amount);
                Console.WriteLine("Pul o'tkazildi!");
                break;

            case 4:
                Console.Write("Hisob raqamingizni kiriting: ");
                string accountNumber2 = Console.ReadLine();
                BankAccount account2 = null;
                foreach (BankAccount acc in customer.Accounts)
                {
                    if (acc.AccountNumber == accountNumber2)
                    {
                        account2 = acc;
                        break;
                    }
                }
                if (account2 == null)
                {
                    Console.WriteLine("Bunday hisob mavjud emas!");
                    break;
                }
                Console.WriteLine("Hisob balansi: " + account2.GetBalance());
                break;

            case 5:
                Console.Write("Hisob raqamingizni kiriting: ");
                string accountNumber3 = Console.ReadLine();
                BankAccount account3 = null;
                foreach (BankAccount acc in customer.Accounts)
                {
                    if (acc.AccountNumber == accountNumber3)
                    {
                        account3 = acc;
                        break;
                    }
                }
                if (account3 == null)
                {
                    Console.WriteLine("Bunday hisob mavjud emas!");
                    break;
                }
                Console.Write("Depozit summasini kiriting: ");
                decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                account3.Deposit(amount2);
                Console.WriteLine("Depozit qo'yildi!");
                break;
                
            case 6:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Noto'g'ri bo'lim tanlandi!");
                break;  
        } 
    }
    catch (Exception)
    {
        Console.WriteLine("Noto'g'ri ma'lumot kiritildi.");
    }   
}