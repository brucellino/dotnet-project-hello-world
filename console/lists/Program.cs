using System;
using System.Collections.Generic;
namespace lists
{
  public static class Globals {
    public static List<string> names = new List<string> { "<name>", "Ana", "Felipe"};
  }

  class Program {
    static void Main(string[] args) {
      var names = Globals.names;
      foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
