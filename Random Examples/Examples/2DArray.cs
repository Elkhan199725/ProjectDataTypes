using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Examples.Examples;

public class _2DArray
{
    public int[,] array2D = new int[,]
        {
            { 0, 1, 2, 3, 4},
            { 10, 11, 12, 13, 14},
            { 20, 21, 22, 23, 24},
            { 30, 31, 32, 33, 34},
        };
    public _2DArray()
    {
        
    }
    public string Format2DArray(int[,] array)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var row in array)
        {
            foreach (var element in array)
            {
                sb.Append(element).Append(',');
            }
        }
        sb.Length--;
        return sb.ToString();   
    }
}
