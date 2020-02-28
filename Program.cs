using System;

namespace holamundo_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            var c2 = 7;
            var c3 = "asd";
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
            Console.WriteLine(c1.ReturnNumber());
            Console.WriteLine(c2.ToString(), c3);
        }
    }
}
