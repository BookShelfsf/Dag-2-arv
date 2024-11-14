// Derived class for Account Admin
using System;

public class AccountAdmin : Person
{
    public int EmployeeId { get; }

    public AccountAdmin(int employeeId, string firstName, string lastName) : base(firstName, lastName)
    {
        EmployeeId = employeeId;
    }
}

// Derived class for Account Owner
public class AccountOwner : Person
{
    public int CustomerId { get; }

    public AccountOwner(int customerId, string firstName, string lastName) : base(firstName, lastName)
    {
        CustomerId = customerId;
    }
}
