namespace _042_CharType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poetry = "日照香炉生紫烟，遥看瀑布挂前川。飞流直下三千尺，疑是银河落九天。\n";
            Console.WriteLine(poetry);                          //输出古诗
            foreach (char item in poetry)
            {
                Console.Write(item);                             //输出古诗中的每一个字和标点
                Console.Write("\t");                             //输出制表符
                if (Char.IsPunctuation(item)) Console.Write("\n\n");//如果字符为标点符号则换行
            }
        }
    }
}
