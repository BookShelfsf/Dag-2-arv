﻿// Base class
public abstract class Person
{
    public string FirstName { get; }
    public string LastName { get; }
    public string FullName => $"{FirstName} {LastName}";

    protected Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}