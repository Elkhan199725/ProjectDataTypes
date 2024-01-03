using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TaskIntegralType.Interfaces;

namespace TaskIntegralType.Entities;

public class TaskIntegerOperations : IValues
{
    private int num1 ;
    private int num2 ;

    public int Number1
    {
        get { return num1; }
        set 
        { 
            num1 = value;
        }
    }

    public int Number2
    {
        get { return num2; }
        set 
        {
            num2 = value;
        }
    }

    public void Addition()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        int Sum = Number1 + Number2;
        Console.WriteLine($"Sum of Number1 and Number2 is: {Sum}");
    }

    public void Decrement()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Decrementing using while loop:");
        while (Number1 > 0) 
        {
            int Decrement = Number1--;
            Console.WriteLine($"Decrement of Number1 is {Decrement}");
        }     
        while (Number2 > 0)
        {
            int Decrement = Number2--;
            Console.WriteLine($"Decrement of Number2 is {Decrement}");
        }       
    }

    public void Divide()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        if (Number2 == 0) throw new DivideByZeroException();
        int Divide = Number1 / Number2;
        Console.WriteLine($"The result of division: {Divide}");
    }

    public void Increment()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        while (Number1 < 10)
        {
            int Increment = Number1++;
            Console.WriteLine($"Increment of Number1 is {Increment}");
        }
        while(Number2 < 10)
        {
            int Increment = Number2++;
            Console.WriteLine($"Increment of Number2 is {Increment}");
        }
    }

    public void Modulo()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        int Modulo = Number1 % Number2;
        Console.WriteLine($"Modul is: {Modulo}");
    }

    public void Multiplication()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        int Multiplication = Number1 * Number2;
        Console.WriteLine($"Multiplication of Number1 and Number2: {Multiplication}");
    }

    public void Subtraction()
    {
        Console.Write("Input for Number1: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input for Number2: ");
        Number2 = Convert.ToInt32(Console.ReadLine());
        int Subtraction = Number1 - Number2;
        Console.WriteLine($"The subtraction of Number1 and Number2 : {Subtraction}");
        Console.WriteLine($"The abstract subtraction of Number1 and Number2 : {Math.Abs(Subtraction)}");
    }
}
