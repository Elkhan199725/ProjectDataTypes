using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegralType.Interfaces;

public interface IValues
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }
    void Addition(int Num1, int Num2, int Sum);
    void Subtraction(int Num1, int Num2, int Substract);
    void Multiplication(int Num1, int Num2, int Multi);
    void Divide(int Num1, int Num2, int Div);
    void Modulo(int Num1, int Num2, int Mod);
    void Increment(int Num1, int Num2, int Inc);
    void Decrement(int Num1, int Num2, int Dec);
}
