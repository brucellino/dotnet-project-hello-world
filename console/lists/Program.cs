using System;
using System.Collections.Generic;
namespace lists
{
  public static class Globals {
    public static List<string> names = new List<string> { "<name>", "Ana", "Felipe"};
  }

  class Program {
    static void Main(string[] args) {
      foreach (var name in Globals.names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
