using System;
using System.Collections.Generic;
namespace lists
{
  public static class Globals {
    public static List<string> names = new List<string> { "<name>", "Ana", "Felipe"};
  }

  class Program {
    static void Strings() {
      var names = Globals.names;
      foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
      Console.WriteLine();

      names.Add("Maria");
      names.Add("Bill");
      names.Add("Ana");

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

    static void Fib() {
      var fibonacciNumbers = new List<int> {1,1};
      var previous = fibonacciNumbers[fibonacciNumbers.Count -1 ];
      var previous2 = fibonacciNumbers[fibonacciNumbers.Count -2 ];

      fibonacciNumbers.Add(previous + previous2);

      foreach(var item in fibonacciNumbers) {
        Console.WriteLine(item);
      }
    }

    static void Main(string[] args) {
      Strings();
      Fib();
    }
  }
}
