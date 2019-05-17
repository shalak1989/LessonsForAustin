using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
  class Program
  {
    //everything in C# is an object (A: everything is a thing)
    static void Main(string[] args)
    {
      var spell = new Spell();
      var fireBallSpell = new FireBall();

      fireBallSpell.Cast();
    }
  }

  public class Spell
  {
    private string _name;

    public void Cast()
    {
      Console.WriteLine("Casting " + Name);
    }

    public string Name { get; set; }

    //public string Name
    //{
    //  get
    //  {
    //    return _name;
    //  }
    //  set
    //  {
    //  if (value == "bitch")
    //  {
    //      Console.WriteLine("DON'T SAY THAT, HIT ANY KEY TO STOP BEING A POTTY MOUTH");
    //      Console.ReadKey();
    //  }
    //  else{
    //      _name = value;
    //    }
    //  }
    //}
  }

  public class FireBall : Spell
  {
    public FireBall()
    {
      Name = "Fireball";
    }
  }
}
