using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> products = new List<int>();

            for (int i = 1; i < 10000; i++)
            {
                for (int j = 1; j < 10000; j++)
                {
                    products.Add(i * j);
                }
            }

            int largestnum = 0;

            for (int i = products.Count - 1; i > 0; i--)
            {
                var h = products[i];
                if (checkPalindrome(h.ToString()))
                {
                    if (h > largestnum) largestnum = h;
                 
                    //break;
                }
            }

            Console.WriteLine(largestnum);
            Console.Read();
        }

        public static bool checkPalindrome(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                    return false;
            }
            return true;
        }
    }
}
