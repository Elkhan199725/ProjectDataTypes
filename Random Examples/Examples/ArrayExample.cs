using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Examples.Examples;

public class ArrayExample
{
    public void OddAndEven(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine($"This is even number: {arr[i]}");
            }
            else if (arr[i] % 2 == 1)
            {
                Console.WriteLine($"This is odd number: {arr[i]}");
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }

    public string StringArrayExample(string word, int countOfWords)
    {
        string result = String.Empty;
        for (int i = 0;i < countOfWords;i++)
        {
            result = result + word;
        }
        Console.WriteLine(result.ToLower());
        return result;
    }
}
