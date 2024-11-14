public class Account
{
    public AccountOwner Owner { get; }
    public AccountAdmin Admin { get; }
    public decimal Balance { get; private set; }

    public Account(AccountOwner owner, AccountAdmin admin, decimal initialBalance)
    {
        Owner = owner;
        Admin = admin;
        Balance = initialBalance;
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine($"Hej {Owner.FullName}. Din konto er oprettet med {Admin.FullName} som admin.");
    }
}
