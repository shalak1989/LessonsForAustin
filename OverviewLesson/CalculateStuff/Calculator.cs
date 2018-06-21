using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateStuff
{
  public class Calculator
  {
    public int Add(int a, int b)
    {
      return a + b;
    }

    public int Subtract(int a, int b)
    {
      return a - b;
    }

    public int Multiply(int a, int b)
    {
      return a * b;
    }

    public int Divide(int a, int b)
    {
      return a / b;
    }

    public int Square(int a)
    {
      return a * a;
    }
  }
}
