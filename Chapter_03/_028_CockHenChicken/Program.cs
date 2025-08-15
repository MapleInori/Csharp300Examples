namespace _028_CockHenChick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 穷举法
            ///一百个铜钱买了一百只鸡，其中公鸡一只五钱，母鸡一只三钱，小鸡三只一钱，问一百只鸡中公鸡、母鸡和小鸡各多少只
            for (int cock = 0; cock <= 20; cock++)          //公鸡数量为0到20只，约束条件1
            {
                for (int chick = 0; chick <= 99; chick += 3)//小鸡数量为0到99只，且是3的倍数，约束条件2
                {
                    int hen = 100 - cock - chick;            //母鸡为100减去公鸡和小鸡的数量，方程1
                    if (hen < 0 || hen > 33) continue;       //母鸡数量在0到33之间，约束条件3
                    if (cock * 5 + hen * 3 + chick / 3 == 100)  //总钱数刚好等于100，方程2，同时满足所有方程即为解
                    {
                        Console.WriteLine("公鸡{0}只 母鸡{1}只 小鸡{2}只", cock, hen, chick);
                    }
                }
            }
        }
    }
}
