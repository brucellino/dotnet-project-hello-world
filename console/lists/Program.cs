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
      var index = names.IndexOf("Felipe");
      if (index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      } else {
        Console.WriteLine($"Then name {names[index]} is at index {index}");
      }

      index = names.IndexOf("Not Found");
      if (index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      } else {
        Console.WriteLine($"Then name {names[index]} is at index {index}");
      }

      names.Sort();
      foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}
