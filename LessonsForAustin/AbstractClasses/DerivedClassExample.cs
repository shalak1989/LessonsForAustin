using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
  class DerivedClassExample : BaseAbstractClassExample
  {
    public override int Subtract(int x, int y)
    {
      return x - y;
    }
  }
}
