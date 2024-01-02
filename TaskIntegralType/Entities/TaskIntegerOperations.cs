using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskIntegralType.Interfaces;

namespace TaskIntegralType.Entities;

public class TaskIntegerOperations : IValues
{
    private int num1;
    private int num2;
    public int Number1 
    { 
        get { return num1; } 
        set { num1 = value; } 
    }
    public int Number2 
    { 
        get { return num2; }
        set {num2 = value; }
    }

    public void Addition(int Num1, int Num2, int Sum)
    {
        Console.WriteLine("Input for num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Num1 = num1;
        Console.WriteLine("Input for num2: ");
        num2 = Convert.ToInt32((Console.ReadLine()));
        Num2 = num2;
        Sum = Num1 + Num2;
        Console.WriteLine($"Sum of num1 and num2 is: {Sum}");
    }

    public void Decrement(int Num1, int Num2, int Dec)
    {
        Console.WriteLine("Input for num1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Num1 = num1;
        Console.WriteLine("Input for num2: ");
        num2 = Convert.ToInt32((Console.ReadLine()));
        Num2 = num2;
        Console.WriteLine("Decrementing using while loop:");
        while (Num1 > 0) 
        {
            Console.WriteLine($"Current value of num2: {Num1}");
            Dec = Num1--;
            Console.WriteLine($"Dec of num1 is {Dec}");
        }     
        while (Num2 > 0)
        {
            Console.WriteLine($"Current value of num2: {Num2}");
            Dec = Num2--;
            Console.WriteLine($"Dec of num2 is {Dec}");
        }       
    }

    public void Divide(int Num1, int Num2, int Div)
    {
        throw new NotImplementedException();
    }

    public void Increment(int Num1, int Num2, int Inc)
    {
        throw new NotImplementedException();
    }

    public void Modulo(int Num1, int Num2, int Mod)
    {
        throw new NotImplementedException();
    }

    public void Multiplication(int Num1, int Num2, int Multi)
    {
        throw new NotImplementedException();
    }

    public void Subtraction(int Num1, int Num2, int Substract)
    {
        throw new NotImplementedException();
    }
}
