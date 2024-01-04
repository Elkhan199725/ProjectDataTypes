using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskIntegralType.Interfaces;

namespace TaskIntegralType.Entities;

public class StringOperation : IStringValues
{
    private string _value1;
    private string _value2;
    public string firstName 
    {
        get
        {
            return _value1;
        }
        set
        {
            _value1 = value;
        }
    }
    public string lastName 
    {
        get 
        {
            return _value2;
        }
        set
        {
            _value2 = value;
        }
    }

    public void Concatenate()
    {
        Console.Write("Input first name: ");
        firstName = Console.ReadLine();
        Console.Write("Input last name: ");
        lastName = Console.ReadLine();
        string fullName = String.Concat(firstName, " ", lastName);
        int lengthFirstName = firstName.Length;
        int lengthLastName = lastName.Length;
        int fullNameLength = fullName.Length;
        string lowerFirstName = firstName.ToLower();
        string upperLastName = lastName.ToUpper();

        Console.WriteLine($"Task 3 results: \n" +
                          $"Concatenated full name: {fullName} \n" +
                          $"First name length: {lengthFirstName} \n" +
                          $"Last name length: {lengthLastName} \n" +
                          $"Full name length: {fullNameLength} \n" +
                          $"Lower first name: {lowerFirstName} \n" +
                          $"Upper last name: {upperLastName}");
    }
}
