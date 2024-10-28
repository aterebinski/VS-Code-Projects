using System;

namespace TestConsoleApp.Models;

public abstract record Person
{
    public record Simple(string FirstName, string LastName) : Person;
    public record WithPesel(string FirstName, string LastName, string Pesel) : Person;
}
