using System;

namespace ConsoleApp1
{
    

    public class Class1
    {
        public string Display()
        {
            return ("I m in Display");
        }

        public string Print()
        {
            return ("I m in Print");
        }
        
    }

    public static class XX
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }

        public static void NewMethod2(this Class1 ob, int a)
        {
            Console.WriteLine("Hello I m extended method 2");
        }
    }

    public static class ExtMetClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }
}