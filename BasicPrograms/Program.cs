using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicPrograms
{
    internal class ABC
    {
        private ABC()
        {
            Console.WriteLine("ABC Constructor is called");
        }
    }

    public interface bce
    {
    }

    internal interface I1
    {
        void Dis();
    }

    internal interface I2
    {
        void Dis();
    }

    public class TestMultipleInheritance : I1, I2
    {
        public string Message { get; set; }

        public void test()
        {
            Console.WriteLine(Message);
        }

        public void Dis()
        {
        }

        void I1.Dis()
        {
        }

        void I2.Dis()
        {
        }

        public void add()
        {
        }

        public void add(int a, float b)
        {
        }

        public void add(float a, int b)
        {
        }
    }

    // C# program to illustrate the concept
    // of how to inherit multiple interfaces
    // with the same method name

    // Interface G1 and G2
    // contains same method
    internal interface G1
    {
        // interface method
        void mymethod();
    }

    internal interface G2
    {
        // interface method
        void mymethod();
    }

    // 'Geeks' implements both
    // G1 and G2 interface
    internal class Geeks : G1, G2
    {
        public void mymethod()
        {
            Console.WriteLine("GeeksforGeeks m");
        }

        //void G1.mymethod()
        //{
        //    Console.WriteLine("GeeksforGeeks 1");
        //}

        //void G2.mymethod()
        //{
        //    Console.WriteLine("GeeksforGeeks 2");
        //}
    }

    internal class MyClassA
    {
        public MyClassA()
        {
            Console.WriteLine("constructor A");
        }

        public virtual void abc()
        {
            Console.WriteLine("A");
        }
    }

    internal class MyClassB : MyClassA
    {
        public MyClassB()
        {
            Console.WriteLine("constructor B");
        }

        public override void abc()
        {
            Console.WriteLine("B");
        }

        public  void show()
        {
            Console.WriteLine("B");
        }

    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            //Geeks g = new Geeks();
            //g.mymethod();

            //G1 obj = new Geeks();

            //obj.mymethod();

            //G2 ob = new Geeks();

            //ob.mymethod();

            MyClassA obj3 = new MyClassB();

            obj3.

            Console.ReadLine();
            Console.ReadKey();
        }

        private static int SomeMethod(int x, int y)
        {
            return (x - y) * (x + y);
        }

        public static void AddTow(out int a)
        {
            a = 10;
            a += 10;
        }

        public static void SumOfDigits()
        {
            int sum = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
        }

        public static void FindPrime1()
        {
            Console.Write("Enter a Number : ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int k;
            k = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Entered Number is a Prime Number and " +
                                  "the Largest Factor is {0}", num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }

        internal static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static void PosibleSubStrings()
        {
            string str = "Nagaich";
            for (int i = 0; i < str.Length; i++)
            {
                var subString = new StringBuilder(str.Length - 1);
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        public static void RemoveDuplicateChar()
        {
            string str = "Occurrence";
            string newStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!newStr.Contains(str[i]))
                {
                    newStr += str[i];
                }
            }

            Console.WriteLine(newStr);
        }

        public static void CountOccurrence()
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            var str = "Occurrence";
            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!charCount.ContainsKey(character))
                    {
                        charCount.Add(character, 1);
                    }
                    else
                    {
                        charCount[character]++;
                    }
                }
            }

            foreach (var item in charCount)
            {
                Console.WriteLine("key {0} -- {1}", item.Key, item.Value);
            }
        }

        public static void StringPalindrome()
        {
            string str = "Madam".ToLower();
            var flag = false;

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            Console.WriteLine(flag);
        }

        public static void ReverseString()
        {
            string str = "Rahul";
            Char[] arr = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                arr[i] = str[j];
                arr[j] = str[i];
            }

            var reverseStr = new string(arr);
            Console.WriteLine(reverseStr);
        }
    }
}