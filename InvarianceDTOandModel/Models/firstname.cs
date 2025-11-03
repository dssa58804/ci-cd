using System;
using System.Text.RegularExpressions;
public class FirstName
{
    private readonly string firstname;
    private const int minChars = 3;
    private const int maxChars = 20;
    public FirstName(string firstname)
    {
        ValidateFirstName(firstname);
        this.firstname = firstname;
    }
    private string ValidateFirstName(string firstname)
    {
        if (string.IsNullOrEmpty(firstname))
            throw new ArgumentException("Firstname can't be empty");
        if (firstname.Length < 2 || firstname.Length > 20)
            throw new ArgumentException("Firstname must be between 2 and 20 characters long");
        if (!Regex.IsMatch(firstname, @"^[a-zA-ZæøåÆØÅ]+$"))
            throw new ArgumentException("Firstname must only contain alphabetical letters");
        return firstname;
    }
    public string GetFirstName()
    {
        return firstname;
    }
}