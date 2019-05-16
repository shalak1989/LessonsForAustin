using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
  //there are several different function types, we will only be dealing with static and non-static
  //the word function and method is often used interchangeably, don't worry about the semantics.

  /*
   * Functions are essentially reusable blocks of code that take in parameters, do work, and may return a value to the caller
   * Functions marked as "void" do not return any value whereas any other function must have a return type
   */
  class Program
  {
    static void Main(string[] args)
    {
      //can call static functions without instance
      StaticFunctions.Hello();

      //NonStaticFunctions.Hello(); //This causes an error because an object reference is required for non-static methods
      var nonStaticFunctions = new NonStaticFunctions(); //This creates an instance of the NonStaticFunctions class

      //Now we can call the Sum method
      var sum = nonStaticFunctions.Sum(1, 2);
      Console.WriteLine("The Sum is " + sum);

      //You don't have to store a functions return value to use it in your program... for example....
      Console.WriteLine("The Sum is " + nonStaticFunctions.Sum(4, 5));

      /*Functions have a concept of pass by value and pass by reference. Value basically means just give the literal value while Reference means
       * the location in memory. For example: int x = 5; 5 would be the value and x would be a variable Referencing (Reference) the location in
       * memory.
       * Whether or not something is passed by value/reference is dependent on the Type of the data being passed. You can look up
       * C# Value and Reference types for more information on the specifics
       * NOTE: You can force something to be a reference type using the "ref" keyword. This is more advanced and we won't be covering
       * it here.... but feel free to look it up
      */

      /*in C# int's are defined as Value types. This means if they are passed into functions just their value is passed.
       * This means that if we pass "x" into a function and change it, the original int x variable will remain unchanged.
       */

      //Example
      int x = 5;
      Console.WriteLine("Before passing x into function: " + x);
      StaticFunctions.AttemptToModifyIntegerVariable(x);
      Console.WriteLine("After passing x into function: " + x);

      /*
       * Lists are one of the Reference types in C# so their memory location gets passed into functions. Due to this
       * you can modify what they contain. This is sometimes referred to as mutation.
       */

      //NOTE: The variables passed into functions/used in them are known as Parameters
      var stringList = new List<string>();
      //this first loop won't even run because stringList is empty
      foreach (var item in stringList)
      {
        Console.WriteLine(item);
      }

      StaticFunctions.ModifyStringListVariable(stringList);

      foreach (var item in stringList)
      {
      
        Console.WriteLine("Now the list contains: " + item);
      }

      /*
  * There is an exception though, if you assign the Reference type variable to something else in the function it will lose its
 * connection back to the original variable
  */
      var anotherListOfStrings = new List<string>();
      anotherListOfStrings.Add("Joe");
      foreach (var item in anotherListOfStrings)
      {
        Console.WriteLine(item);
      }

      /*Even though this function reassigns the parameter to a different list they are now not connected. This is because
       * we aren't actually passing anotherListOfStrings into the function, we are passing a "Reference" or a location in memory
       * into the function. By reassigning the parameter in the function we are pointing it to a different place.
       */
      StaticFunctions.BreakingStringListReference(anotherListOfStrings);
      //If the above function modified the list successfully it should print out Joe and Stan
      //Since we broke the reference in the function, it still only contains Joe
      foreach (var item in anotherListOfStrings)
      {
        Console.WriteLine(item);
      }
      
      Console.WriteLine("Hit any key to close program");


      Console.ReadKey();

    }
  }

  //Even though all functions must exist inside of a class, static functions do not have to based on an instance of an object
  //NOTE static functions can exist on non-static classes
  public class StaticFunctions
  {
    public static void Hello()
    {
      Console.WriteLine("Hello");
    }

    public static int Sum(int x, int y)
    {
      return x + y;
    }

    public static void AttemptToModifyIntegerVariable(int x)
    {
      x = 100;
    }


    public static void ModifyStringListVariable(List<string> x)
    {
      x.Add("Bob");
    }

    public static void BreakingStringListReference(List<string> x)
    {
      x = new List<string>();
      x.Add("Stan");
    }
  }

  //functions inside of classes not marked as static can only be accessed on an instance of the class
  public class NonStaticFunctions
  {
    public void Hello()
    {
      Console.WriteLine("Hello");
    }

    public int Sum(int x, int y)
    {
      return x + y;
    }

  }
}
