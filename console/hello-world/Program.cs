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

    static void QuotientRemander() {

        int a = 7;
        int b = 4;
        int c = 3;
        int d = (a + b) / c;
        int e = (a + b) % c;

        Console.WriteLine($"quotient {d}");
        Console.WriteLine($"remainder {e}");
    }

    static void WorkWithDoubles() {
      double max = double.MaxValue;
      double min = double.MinValue;
      Console.WriteLine($"The range of double is {min} to {max}.");
      // Challenge WorkWithDoubles():
      /*
      Try other calculations with large numbers, small numbers, multiplication and division using the double type. Try more complicated calculations.
      */
      double a = 1.1000000000000000000;
      double b = 1.500000001;
      double c = a * b;
      Console.WriteLine($"{a} times {b} is {c}");

    }

    static double Area(double r) {
      return (double)(Math.PI)* r*r;
    }

    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      Console.WriteLine("The time is " + DateTime.Now);
      Numbers();
      OrderOfPrecedence();
      QuotientRemander();
      WorkWithDoubles();

      Console.WriteLine(Area(2.5));
    }
  }
}
