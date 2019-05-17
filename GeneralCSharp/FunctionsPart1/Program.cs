using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsPart1
{
  class Program
  {
    /*functions are one of the most important things you will learn about in programming.
     * effectively you can encapsulate any block of code into a function for reuse later
     * functions can also be used to make code make more sense. Instead of having 150 lines of code in a row, you can break it into smaller functions
     * so it is easier to read and understand your programs workflow.
     */
    static void Main(string[] args)
    {
      SayHello();
      //number will now contain 5 which is the return value of the Add function
      var number = Add(2, 3);
      Console.WriteLine(number);
      //can do more complex things
      var complexThing1 = Add(2, 3) + Multiply(5, 5);
      Console.WriteLine(complexThing1);
      //var hello = SayHello(); //Cannot do this because you can not assign "void" to a variable and SayHello's return type is "void"

      /*Just because a function has a return type doesn't mean you have to use it. However, in most cases when you have a function that returns something
      you probably want to use the return value.
      */

      //This still runs the function but when 5 is returned it is returned to "nowhere" and effectively just disappears.
      Add(2, 3);


      //You can also call functions inside of functions
      string name = "Ali";
      //The function below will take name, and simple pass it into the SayHelloName function. This will cause the console to say "Hello Ali"
      CallingOtherFunctionsSimple(name);

      /*The below function takes 10 and passes it through multiple functions to get a different number. The final number is then sent back and stored
      indexer the result variable
      */
      var result = CallingOtherFunctionsComplex(10);
      Console.WriteLine(result);
    }

    public static void SayHello()
    {
      Console.WriteLine("Hello");
    }

    public static void SayHelloName(string name)
    {
      Console.WriteLine("Hello " + name);
    }

    public static int Add(int x, int y)
    {
      //could also store x + y in a variable and return the variable. Because this is a simple calculation there is no need to though
      //EX: int answer = x + y;
      //    return answer;
      return x + y;
    }

    public static int Multiply(int x, int y)
    {
      return x * y;
    }

    public static int Subtract(int x, int y)
    {
      return x - y;
    }

    public static int CallingOtherFunctionsComplex(int x)
    {
      //each time you modify x you can then pass it to another function and modify it more
      x = Add(1, x);
      x = Multiply(x, 10);
      x = Subtract(x, 5);

      return x;
    }

    public static void CallingOtherFunctionsSimple(string name)
    {
      SayHelloName(name);
    }
  }
}
