using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
  public class Class1
  {
    public void Variables()
    {
      //Every variable in C# has a type. A variable is effectively a storage container(location in memory) for a piece of data.

      //Another important note: every unintialzied variable has a default value.

      //Example of uninitialized
      int numNotInitialized;
      //Example of initialized
      int numInitialized = 12;

      //common number types
      int number = 0;
      double doubleNumber = 120.235;
      //floats must end in the character f, they are simialr to doubles but have a different decimal precision 
      float c = 120.235f;
      //decimal is also similar to double and float. I would recommend googling the differences
      decimal decimalNumber = 1230.234234234m;

      /*string (think words), char(think single character). Strings are a bit special too because they function like arrays.
       * a string is effectively an array of char(s) so you can go name[0] and it would give you "N", name[1] would give you "a" etc.
      */
      string name = "Name";
      char theLetterA = 'A'; //If you try to assign more than one letter to a char variable you will get an error
                             //char f = 'AB'; -- Will give error "too many characters in character literal

      //Variables can also store/be a Class as well. We will use a class we created called Example
      Example example;

      /* Collection variables, there are others not mentioned but arrays, lists, and dictionaries will be the most common
       * You can have arrays, lists, and dictionaries of virtually any type (string, int, classes even)
       */
      string[] stringArray;
      List<string> stringList;
      Dictionary<string, string> stringDictionary;
      List<Example> examplesList;
      Example[] exampleArray;

      /* C# also has a keyword called "var". var infers the variable type based on what is assigned to the right side of it
       * NOTE: assignment, or the assignment operator rather is '=' in C#,
      */

      /*test will be an int, the compiler can infer this before the program runs. This means that from this point on in the code
      test can only hold ints
      */
      var test = 1;
      //test = "bob"; -- Throws an error saying cannot implicitly convert type string to int, C# will only allow ints into test now
      test = 100; //this is fine because 100 is an int
      //test = 100.230; //This will cause an error because 100.230 is a floating point number, int can only hold whole numbers

      /*More var examples - note you will see a lot of C# code in the real world that uses var whenever possible, this is for convenience
      and the ability to easily switch around types later if code changes. Basically get very comfortable working with it.
      */
      var varStringArray = new string[10];
      var varStringList = new List<string>(); //This is the same thing as typing 
      List<string> varStringList2 = new List<string>();
      var varChar = 'A'; //This is the same thing as typing char varChar = 'A';
      var varDictionary = new Dictionary<string, string>();

      //Bool type
      bool trueBool = true;
      bool falseBool = false;
      bool nonInitializedBoolean; //Bool's default value is false if you don't explicitly set it (important to remember)
    }

  }

  public class Example
  {

  }
}
