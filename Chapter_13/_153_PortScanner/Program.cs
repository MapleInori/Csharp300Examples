using System.Net.Sockets;

namespace _153_PortScanner
{
    internal class Program
    {
        static string ip = "127.0.0.1"; // 默认扫描本地主机

        static void Main(string[] args)
        {
            Console.WriteLine("开始扫描{0}...", ip);
            for (int port = 1; port <= 1024; port++)                //扫描1到1024号端口
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(PortScan), port);//创建端口扫描线程
            }
            Console.ReadKey();
        }
        static void PortScan(object port)                   //端口扫描线程函数
        {
            try
            {
                TcpClient client = new TcpClient();           //创建TCP套接字
                client.Connect(ip, (int)port);                //尝试与指定IP和端口连接
                if (client.Connected)                         //连接成功
                {
                    Console.WriteLine("端口{0}开放！", port);
                }
            }
            catch { }                                        //连接失败
            if ((int)port == 1024) Console.WriteLine("扫描完毕！");
        }
    }
}
