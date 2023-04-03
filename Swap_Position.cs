using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Swap_Position
    {
        public static void swapping()
        {
            Console.WriteLine("Enter how many nuumber of groups");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] words = Console.ReadLine().Split();
                if (words[0].Length != words[1].Length)
                {
                    Console.WriteLine("NO");
                }
                else if (words[0].OrderBy(c => c).SequenceEqual(words[1].OrderBy(c => c)))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }

}

