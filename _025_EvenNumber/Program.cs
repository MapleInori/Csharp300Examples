namespace _025_EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if (++i % 2 != 0) continue;                      //如果为奇数，则跳过此次循环
                Console.Write(i);
                if (i % 5 == 0) Console.WriteLine();             //每5个数一行
                else Console.Write("\t");
            } while (i < 20);
        }
    }
}
