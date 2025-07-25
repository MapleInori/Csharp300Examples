﻿namespace _006_JudgeRectIsSquare
{
    internal class Program
    {
        struct Rectangle
        {
            public int Width;                                    //矩形宽度
            public int Height;                                   //矩形高度
            public bool IsSquare() { return Width == Height; }      //判断矩形是否为正方形
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();                       //创建一个矩形对象
            rect.Width = 100;                                       //设置矩形宽度为100
            rect.Height = 100;                                      //设置矩形高度为100
            Console.WriteLine("矩形宽:{0} 矩形高:{1}", rect.Width, rect.Height);
            //输出矩形宽度和高度
            bool isSquare = rect.IsSquare();                        //获取矩形是否为正方形
            Console.WriteLine("矩形是否为正方形:{0}", isSquare);       //输出矩形是否为正方形
        }
    }
}
