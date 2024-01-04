using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Random_Examples.Examples;

public class BeginnerMethods
{
    public string result;
    public BeginnerMethods()
    {
        result = String.Empty;
    }
    public string GetMerger(string word, int count)
    {
        while(count > 0)
        {
            result += word;
            count--;
        }
        return result;
    }

    public int GetMaxValue(params int[] arr)
    {
        int max = arr[0];
        foreach(var i in arr)
        {
            if (max < i)
            {
                max = i;
            }
        }
            return max;
    }
}
