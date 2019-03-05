using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractClasses;

namespace Collections
{
  class Program
  {
    static void Main(string[] args)
    {
      //types of collections

      //Lists, remember these are "arrays that can resize"
      var list = new List<string>();
      list.Add("bob");
      //You can also add multiple values at once
      var namesToAddToList = new List<string> { "joe", "manny" };
      list.AddRange(namesToAddToList);
      //print out the values in the list
      foreach (var name in list)
      {
        Console.WriteLine(name);
      }

      //Arrays
      //array variables must be given a size
      //Working with arrays should be similar but you have to resize them if you run out of space
      var array = new string[3];
      array[0] = "bob";
      array[1] = "bob";
      array[2] = "bob";
      //this line below would cause an error, this array can only hold 3
      //array[3] = "bob";
      //To get more space you must make a new array and you probably want to copy the old values over
      //There may be a shorter syntax for this but I am not aware of it right now
      var newArray = new string[4];
      array.CopyTo(newArray, 0);
      newArray[3] = "bob";


      //dictionaries are key value pairs
      //You must declare the types, so you could have a int key with a string value, etc.
      var dictionary = new Dictionary<string, string>();
      dictionary.Add("bob", "bob is a fat old man");
      dictionary.Add("sue", "sue is a fat old woman");
      dictionary.Add("joe", "joe is a fat old man");

      //This is accessing the value stored at the key "bob"
      Console.WriteLine(dictionary["bob"]);
      //you can store any type inside of a dictionary, even a self defined class.
      var test = new Dictionary<string, DerivedClassExample>();
      test.Add("bob", new DerivedClassExample());
      Console.WriteLine(test["bob"].Multiply(new List<int> { 2, 3, 4, 5}));

    }
  }
}
