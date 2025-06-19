namespace _023_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入1到10之间的整数：");
            int prime = int.Parse(Console.ReadLine());

            switch (prime)
            {
                case 1:
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("{0}为素数", prime);
                    break;
                case 4:
                case 6:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("{0}为合数", prime);
                    break;
                default:
                    break;
            }
            // 当switch中的参数与某一个case匹配时，程序会执行该case下的代码块
            // 而如果该case下没有代码块，会向后查找下一个case，直到找到一个有代码块的case为止
        }
    }
}
