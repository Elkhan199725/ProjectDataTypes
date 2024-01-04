using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIntegralType.Interfaces;

public interface IStringValues
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public void Concatenate();
}
