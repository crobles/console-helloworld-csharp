using System;

namespace holamundo_csharp
{
    public class MyClass
    {
        public MyClass(){
            Console.WriteLine("constructor");
        }
        public string ReturnMessage()
        {
            return "Happy coding!";
        }

        public int ReturnNumber(){
            return 7;
        }
    }
}