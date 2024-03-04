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

            // vd mảng 2 chiều
            int[,] number = { { 1, 2, 3 }, { 4, 5, 6 } };
            int max = number[0, 0];
            int a = 0;int b = 0;
            for(int i=0; i<number.GetLength(0); i++)
            {
                for(int j = 0; j < number.GetLength(1); j++)
                {
                    if (number[i, j] > max)
                    {
                        max = number[i, j];
                        a = i;
                        b = j;
                    }
                }
            }
            Console.WriteLine("Phần tử lớn nhất trong mảng là :" + max+" và ở vị trí dong "+(a+1) +" cột "+(b+1));


            Console.ReadKey();
          
        }
    }
}
