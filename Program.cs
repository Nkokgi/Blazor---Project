using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Project
{
    class Program
    {

        public static List<int> GetIntegers()
        {
            var integerList = new List<int>();
            for (var i = 1; i <= 100; i++)
            {
                integerList.Add(i);
            }
            return integerList;
        }
        public static void FizzBuzz(List<int> integerList)
        {
            foreach (var item in integerList)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (item % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine(item + "Buzz");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Main(string[] args)
        {

            var integerList = GetIntegers();
            FizzBuzz(integerList);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    }
