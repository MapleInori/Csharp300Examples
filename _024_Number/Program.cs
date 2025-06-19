namespace _024_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                Console.Write(i);
                if (i % 5 == 0) Console.WriteLine();             //每5个数换行输出
                else Console.Write("\t");
                if (++i > 20) break;                             //当i大于20时跳出循环
            }
        }
    }
}
