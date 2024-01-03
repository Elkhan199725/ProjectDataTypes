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
    void Addition();
    void Subtraction();
    void Multiplication();
    void Divide();
    void Modulo();
    void Increment();
    void Decrement();
}
