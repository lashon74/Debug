using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        ///Debugging use F5 to run while in debug mode then use F10 allows you to spet over 
        ///F11 allow you to step into each item to see if it is getting the information like it is supposed to
        ///F9 is how you can put a break point then go to the tabs debug window and watch type in the elements you wanna watch
        ///
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i > list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
