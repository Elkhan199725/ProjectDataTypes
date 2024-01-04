using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegralType.Entities;

public class NullableOperation
{
    public int? nullableInt;

    public NullableOperation()
    {
        nullableInt = 50;
    }
    
    public void NullableInt()
    {
        nullableInt = null;
        string result = nullableInt?.ToString()?? "Value is null";
        Console.WriteLine($"{result}");
    }
}
