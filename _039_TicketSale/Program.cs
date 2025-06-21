namespace _039_TicketSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool[,] seats = new bool[20, 5];                    //座位状态表
            for (int row = 0; row < 20; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    seats[row, column] = random.Next(2) >= 1;            //随机生成座位状态
                    //输出座位状态
                    // 行号乘列数 加 列号 就是座位索引，但由于下标从0开始，所以索引加1就是实际座位号
                    Console.Write("[{0:D3}{1}]  ", row * 5 + column + 1, seats[row, column] ? "已售" : " 空 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("请输入座号：");
            int number = int.Parse(Console.ReadLine());         //输入座位号
            if (seats[(number - 1) / 5 , (number - 1) % 5])
                Console.WriteLine("{0}号座车票位已售出！", number);
            else
            {
                seats[(number - 1) / 5 , (number - 1) % 5] = true;   //将座位设置成已售状态
                Console.WriteLine("{0}号座位车票成功售出！", number);
            }
        }
    }
}
