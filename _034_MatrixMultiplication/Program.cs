﻿namespace _034_MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrixA = new int[3, 4];                     //矩阵A
            int[,] matrixB = new int[4, 5];                     //矩阵B
            Console.WriteLine("矩阵A：");
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matrixA[r, c] = random.Next(10);              //为矩阵A赋值
                    Console.Write("{0}\t", matrixA[r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("矩阵B：");
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    matrixB[r, c] = random.Next(10);              //为矩阵B赋值
                    Console.Write("{0}\t", matrixB[r, c]);
                }
                Console.WriteLine();
            }
            int[,] matrixProduct = new int[3, 5];               //乘积矩阵
            Console.WriteLine("矩阵A乘以矩阵B：");
            for (int r = 0; r < 3; r++)                         //遍历乘积矩阵的行
            {
                for (int c = 0; c < 5; c++)                      //遍历乘积矩阵的列
                {
                    for (int i = 0; i < 4; i++)
                    {
                        //矩阵A的行元素与矩阵B的列元素对应相乘后求和赋值给乘积矩阵
                        matrixProduct[r, c] += matrixA[r, i] * matrixB[i, c];
                    }
                    Console.Write("{0}\t", matrixProduct[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
