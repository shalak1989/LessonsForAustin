using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
  public abstract class BaseAbstractClassExample
  {
    public int Add(int x, int y)
    {
      return x + y;
    }

    public abstract int Subtract(int x, int y);

    public virtual int Multiply(int x, int y)
    {
      return x * y;
    }
  }
}
