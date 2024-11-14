using System.Security.Principal;

class Program
{
    static void Main()
    {
        // Opret en AccountAdmin
        AccountAdmin admin = new AccountAdmin(120207, "John", "Doe");

        // Opret en AccountOwner
        AccountOwner owner = new AccountOwner(200812, "Lukas", "Frederiksen");

        // Opret en Account
        Account account = new Account(owner, admin, 1000m);

        // Udskriv konto information
        account.PrintAccountInfo();
    }
}
