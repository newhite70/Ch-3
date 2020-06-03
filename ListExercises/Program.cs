using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static int SumOfEvens(List<int> numbString)
        {
            int sum = 0;

            foreach (int i in numbString)
                if (i % 2 == 0)
                {

                    sum += i;
                }
            return sum;
        }
        static void StringPrinter(List<string> stringList)
        {
            Console.WriteLine("What number of letters do you want to search for:");
            string input = Console.ReadLine();
            int inputNum = int.Parse(input);

            foreach (string i in stringList)
            if (i.Length == inputNum)
            {
                    Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> people = new List<string> { "hello", "nope", "John", "Jossy", "Brittany", "Six", "Seven", "Three" };

            int sum = SumOfEvens(numbers);

            Console.WriteLine(sum);

            StringPrinter(people);
        }


    }
}
