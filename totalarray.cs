using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wo2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int[] number = { 1, 2, 3, 4, 5 };
            int total = 0;
            for(int i=0; i < number.Length; i++)
            {
                Console.WriteLine("Phần tử thứ " + (i + 1) + " là :" + number[i]);
                total += number[i];
            }
            Console.WriteLine("Tổng giá trị của mảng là :" + total);
            Console.ReadKey();
        }
    }
}
