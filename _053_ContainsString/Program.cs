﻿namespace _053_ContainsString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《静夜思》");
            string[] poetry = new string[] { "床前明月光，", "疑是地上霜。", "举头望明月，", "低头思故乡。" };
            foreach (string sentence in poetry) Console.WriteLine(sentence);//输出诗句
            Console.WriteLine("含有“明月”的诗句为：");
            foreach (string sentence in poetry)
            {
                if (sentence.Contains("明月")) Console.WriteLine(sentence); //输出含有“明月”的诗句
            }
        }
    }
}
