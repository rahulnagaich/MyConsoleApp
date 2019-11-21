using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    

    public interface A
    {
        void Test();
    }
    public interface B
    {
        void Test();
    }

    public class MyClass
    {
        public int Foo { get; }

        public MyClass(string name)
        {
            Foo = 5;
        }
    }
    
    public class C
    {
        
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass("");
            Console.WriteLine(myClass.Foo);

            // var objC = new C();
            //A a = objC;
            //a.Test();
            //objC.Test();

            //var cl1 = new Class1();

            //cl1.NewMethod();

            //cl1.NewMethod2(1);

            //XX.NewMethod(cl1);

            //string str = "123456";
            //int num = str.IntegerExtension();
            //Console.WriteLine("The output using extension method: {0}", num);

            //var actions = new List<Action>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);

            //        actions.Add(
            //        () => Console.WriteLine("fdfdfd   " + i)
            //        ); 
            //}

            //foreach (var action in actions)
            //    action();

            //bool isComplete = false;

            //var t = new Thread(() =>
            //{
            //    int i = 0;
            //    while (!isComplete) i += 0;
            //});

            //t.Start();

            //Thread.Sleep(500);
            //isComplete = true;
            //t.Join();
            //Console.WriteLine("complete!");

            //class1 a = new class3();
            //class2 b = new class3();
            //class3 c = new class3();
            //Console.WriteLine(a.DoSomething());
            //Console.WriteLine(b.DoSomething());
            //Console.WriteLine(c.DoSomething());

            //int? i = 0;
            //++i;
            //Console.WriteLine("Value of i is {0} ", i);
            //i++;
            //Console.WriteLine("Value of i is {0} ", i);
            //++i;
            //Console.WriteLine("Value of i is {0} ", i);

            //double dVal = 100.1;
            //Console.WriteLine((int)dVal);

            //object objVal = dVal;
            //Console.WriteLine(Convert.ToInt16(objVal));

            //char x = 'X';
            //int i = 0;
            //Console.WriteLine(true ? x : 0);
            //Console.WriteLine(false ? i : x);

            //int x = 1975;
            //int y = 2015;
            //x ^= y ^= x ^= y;
            //Console.WriteLine("x = " + x + "; y = " + y);

            //C Puzzler = null;
            //Console.WriteLine(C.get());

            //Double i = Double.NaN;

            //Console.WriteLine("Hello  " + i);

            //while (i != i)
            //{
            //    Console.WriteLine("Hello  iiiii   " + i);
            //}

            

            Console.ReadLine();
        }

        private static String get()
        {
            return "i am a C# puzzler";
        }

        public class class1
        {
          public  class1()
            {
                Console.WriteLine("===class1===");
            }
            public virtual string DoSomething()
            {
                return "class1";
            }
        }

        public class class2 : class1
        {
            public class2()
            {
                Console.WriteLine("===class2===");
            }
            public override string DoSomething()
            {
                return "class2";
            }
        }

        public class class3 : class2
        {
            public class3()
            {
                Console.WriteLine("===class3===");
            }
            public new string DoSomething()
            {
                return "Class3";
            }
        }

        public void Test()
        {
            Console.WriteLine("Test Child Called");
        }

        public void Test(int a, string b)
        {
            Console.WriteLine("Test Child Called");
        }

        public string Test(string b, int a)
        {
            return "Rahul";
        }

        //public void Test(string b, int a)
        //{
        //    Console.WriteLine("Test Child Called");
        //}
    }
}
