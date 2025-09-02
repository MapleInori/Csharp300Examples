using System;

namespace _148_GroupMessages
{
    internal class Program
    {
        public static Random random = new Random();                //随机数生成器
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)                        //给10个用户发送短信
            {
                int number = random.Next(100000000);             //随机生成手机号码
                Thread thread = new Thread(new ParameterizedThreadStart(SendMessage));//创建线程
                thread.Start("138" + number);                    //启动线程
            }
            Console.ReadKey();
        }

        static void SendMessage(object? user)                //发送短信线程函数
        {
            Console.WriteLine("正在向用户{0}发送祝福短信：中秋节快乐！", user);
            Thread.Sleep(random.Next(10));                   //随机等待发送短信完成
            Console.WriteLine("用户{0}接收短信成功！", user);
        }
    }
}
