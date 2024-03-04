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
            int a;
            Console.WriteLine("Xin nhập kích thước ma trận vuông:");
            a = int.Parse(Console.ReadLine());
            if (a > 5)
            {
                Console.WriteLine("Xin lỗi, ma trận kích thước lớn quá");
                Console.WriteLine("Xin nhập kích thước ma trận vuông:");
                a = int.Parse(Console.ReadLine());

            }
            else if(a <1)
            {
                Console.WriteLine("Xin lỗi, ma trận kích thước không nhỏ hơn 2");
                Console.WriteLine("Xin nhập kích thước ma trận vuông:");
                a = int.Parse(Console.ReadLine());
            }
            double[,] maTran = new double[a, a];
            // Nhập giá trị cho ma trận
            Console.WriteLine("Nhập giá trị cho ma trận vuông:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"Nhập giá trị tại [{i + 1}][{j + 1}]: ");
                    maTran[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double tong = 0;
            // tính tong duong chéo;
            for( int i=0; i<maTran.GetLength(0); i++)
            {
                tong += maTran[i, i];
            }
            Console.WriteLine("Tổng số đường chéo ma trận là : "+ tong);


            Console.ReadKey();
          
        }
    }
}
