﻿namespace _014_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入学生成绩：");
            int Result = int.Parse(Console.ReadLine());             //从控制台输入学生成绩

            if (Result >= 85) Console.WriteLine("学生成绩为 A");
            if (Result < 85 && Result >= 70) Console.WriteLine("学生成绩为 B");
            if (Result < 70 & Result >= 60) Console.WriteLine("学生成绩为 C");
            if (Result < 60) Console.WriteLine("学生成绩为 D");
        }
    }
}
