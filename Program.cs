using System;

namespace hello_world {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
      Console.WriteLine("The time is " + DateTime.Now);
      Numbers();
    }
    static void Numbers() {
      int a = 18;
      int b = 6;
      int c = a + b;
      Console.WriteLine(c);
    }
  }
}
