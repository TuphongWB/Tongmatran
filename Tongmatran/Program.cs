using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tongmatran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập kích thước của ma trận vuông:");
            int size = Convert.ToInt32(Console.ReadLine());

            double[,] matrix = new double[size, size];

            // Nhập giá trị cho ma trận từ người dùng
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Nhập giá trị của phần tử [{0},{1}]: ", i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma trận đã nhập:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Tính tổng các phần tử trên đường chéo chính
            double diagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine("Tổng của các số trên đường chéo chính là: {0}", diagonalSum);
            Console.ReadKey();
        }
    }
}
