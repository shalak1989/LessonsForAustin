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

    public virtual int Multiply(List<int> numbers)
    {
      int answer = 1;
      foreach (var number in numbers)
      {
        answer = answer * number;
      }
      return answer;
    }

  }
}


//Some random LINQ stuff below:

//var findNumber5 = numbers.Where(x => x == 5);

////this foreach loop is the same thing as the lambda expression above
//var fiveCount = 0;
//      foreach (var x in numbers)
//      {
//        if (x == 5)
//        {
//          fiveCount++;
//        }
//      }

//      Console.WriteLine("I found " + findNumber5.Count() + " 5's");