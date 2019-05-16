using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Loops are used to either do an action until a condition is met or loop through a collection (List, Array, etc) until 
      there are no more results
      */

      /*for loops are the most common loop in programming. 
       * You can use them to do an action for a set number of times like below
      */
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }

      //You can also use them to loop through collections based on length/count. You have to use an index though in a for loop
      var strings = new List<string> { "dog", "cat", "whale", "bird", "fish"};
      for (int i = 0; i < strings.Count; i++)
      {
      //i starts at 0 so you can use index 0, then index 1, and so on (lists have indexes just like arrays)
        Console.WriteLine(strings[i]);
      }

      //Don't be afraid of nested loops either. 
      //Lets loop through each character of each string in the strings variable
      for (int i = 0; i < strings.Count; i++)
      {
        //we are using i, which on the first loop is 0 to access the string at strings[0] which is dog
        for (int j = 0; j < strings[i].Length; j++)
        {
          //now we are saying, for the string at index i (first loop is 0) loop through all of the characters
          //j represents the index of each character at strings[i]
          //This on the first loop will print out d, o, then g
          Console.WriteLine(strings[i][j]);
        }
      }

      /*
       * I am not sure but you can probably nest loops almost infinitely although it is not recommended. You will often not see
       * nested loops like above. However something that would be common would be to loop through a List of classes which have other
       * lists on them. Like a List of businesses which each have a list of clients
       */

      /*
       * foreach loops are very similar except there are some differences. One key difference is in a foreach loop you are not allowed
       * to modify the contents in a collection/list while in a for loop you can. If you try to modify/add things in a foreach loop
       * you will get an exception which says something like "Collection was modified; enumeration operation may not execute."
       * This means the intent of foreach loops is to just loop through data and do something with it (like modify it or move it to 
       * another list)
       */

       //this will print out just like the for loop above
      foreach (var item in strings)
      {
        Console.WriteLine(item);
      }

      //nested foreach loops can often be more readable than nested for loops

      foreach (var str in strings)
      {
        foreach (var chr in str)
        {
        //same as our nested for loop from before
          Console.WriteLine(chr);
        }
      }

      //while

      //do while
    }
  }
}
