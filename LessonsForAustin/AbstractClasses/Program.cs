using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      var example = new DerivedClassExample();
      Console.WriteLine(example.Multiply(20, 20));
    }
  }
}
