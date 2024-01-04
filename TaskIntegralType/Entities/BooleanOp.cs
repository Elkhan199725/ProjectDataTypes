using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegralType.Entities;

public class BooleanOp
{
    public bool isTrue = true;
    public bool isFalse = false;

    public void Logical()
    {
        bool resultAnd = isTrue && isFalse;
        bool resultOr = isTrue || isFalse;
        bool resultNot = !isTrue;

        Console.WriteLine($"Task 4 results: \n" +
            $"isTrue and isFalse {resultAnd} \n" +
            $"isTrue and isFalse {resultOr} \n" +
            $"!isTrue {resultNot}");
    }
}
