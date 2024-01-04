using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegralType.Entities;

public class ArrayOp
{
    int[] myIntArr;
    string[] myStringArr;

    public ArrayOp()
    {
        Array.Sort(myIntArr = new int[] { 10, 15, 5, 310, 51 });
        Array.Sort(myStringArr = new string[] { "Hi", "Hello", "Greetings", "What's up?", "Hey" });
    }

    public void PrintInt()
    {
        foreach (var i in myIntArr)
        {
            Console.WriteLine($"myIntArr values: {i} \n");
            
        }
        Console.WriteLine($"myIntArr length is: {myIntArr.Length}");
        foreach (var i in myStringArr)
        {
            Console.WriteLine($"myStringArr values: {i} \n");
        }
        Console.WriteLine($"myStringArr length is: {myStringArr.Length}");
        string[] stringIntArray = myIntArr.Select(x => x.ToString()).ToArray();
        var concatenatedArray = stringIntArray.Concat(myStringArr).ToArray();
        Console.WriteLine(concatenatedArray);
    }
}
