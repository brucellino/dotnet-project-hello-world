using System;

namespace hello_world {
  class Program {

    static void Numbers() {
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine(c);
    }

    static void OrderOfPrecedence() {
      int a = 5;
      int b = 4;
      int c = 2;
      int d = a + b + c;

      Console.WriteLine(d);

      d = (a+b)*c;
      Console.WriteLine(d);

      int e = 7;
      int f = 4;
      int g = 3;
      int h = (e + f)/g;
      Console.WriteLine(h);

    }

    static void QuotientRemandiner() {

        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;

        Console.WriteLine($"quotient {d}");
        Console.WriteLine($"remainder {e}");
    }
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      Console.WriteLine("The time is " + DateTime.Now);
      Numbers();
      OrderOfPrecedence();
      QuotientRemandiner();
    }
  }
}
