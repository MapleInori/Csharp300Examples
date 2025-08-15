namespace _093_Singleton
{
    class Helicopter
    {
        static Helicopter helicopter;                    //直升机实例
        public static Helicopter Instance
        {
            get
            {
                if (helicopter == null)                    //如果直升机未创建
                    helicopter = new Helicopter();         //延迟创建直升机实例
                return helicopter;
            }
        }
        protected Helicopter() { }                       //直升机受保护的构造方法
        int insecticide = 100;                           //杀虫剂
                                                         //为指定城市的果园喷洒杀虫剂
        public void SprayInsecticide(string city)
        {
            this.insecticide -= 50;
            Console.WriteLine("为{0}的果园喷洒杀虫剂！", city);
            if (this.insecticide == 0)
                Console.WriteLine("杀虫剂已用完！");
            else
                Console.WriteLine("杀虫剂还剩{0}吨！", this.insecticide);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Helicopter bjHelicopter = Helicopter.Instance;      //获取北京直升机
            bjHelicopter.SprayInsecticide("北京");               //为北京果园喷洒杀虫剂
            Helicopter shHelicopter = Helicopter.Instance;      //获取上海直升机
            bjHelicopter.SprayInsecticide("上海");               //为上海果园喷洒杀虫剂
        }
    }
}
