using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            int multiplier;

            for (var i = 0; i <= 19; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter for how much you want to multiply the array: ");
            multiplier = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i <= 19; i++)
            {
                nums[i] = nums[i] * multiplier;
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }
    }
}
