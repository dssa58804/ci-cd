using System;
using System.Text.RegularExpressions;
public class LastName
{
    private readonly string lastname;
    private const int minChars = 3;
    private const int maxChars = 20;
    public LastName(string lastname)
    {
        ValidateLastName(lastname);
        this.lastname = lastname;
    }
    private string ValidateLastName(string lastname)
    {
        if (string.IsNullOrEmpty(lastname))
            throw new ArgumentException("Last name can't be empty");
        else if (lastname.Length < 2 || lastname.Length > 20)
            throw new ArgumentException("Last name must be between 2 and 20 characters long");
        else if (!Regex.IsMatch(lastname, @"^[a-zA-ZæøåÆØÅ]+$"))
            throw new ArgumentException("Last name must only contain alphabetical letters");
        return lastname;
    }
    public string GetLastName()
    {
        return lastname;
    }
}