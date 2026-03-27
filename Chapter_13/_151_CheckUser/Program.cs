namespace _151_CheckUser
{
    internal class Program
    {
        //在线用户列表，Key为用户编号，Value为用户在线时长
        static Dictionary<int, int> users = new Dictionary<int, int>();
        static Random random = new Random();
        static void Main(string[] args)
        {
            Timer timerCheck = new Timer(new TimerCallback(Check), null, 0, 1000);//创建并启动定时器
            ThreadPool.QueueUserWorkItem(new WaitCallback(Login));//创建并启动用户登录线程
            Console.ReadKey();
        }
        static void Login(object? state)                 //用户登录线程函数
        {
            while (true)
            {
                lock (users)
                {
                    int user = random.Next(20);           //随机生成登录的用户编号
                    if (!users.ContainsKey(user)) users.Add(user, 1); //将用户添加到在线用户列表中
                    else users.Remove(user);              //如果已经在线，将用户从在线用户列表中删除
                }
                Thread.Sleep(random.Next(1000));         //随机生成用户登录时间
            }
        }
        static void Check(object? state)                     //检测用户在线时长线程函数
        {
            lock (users)
            {
                Console.Clear();
                for (int user = 0; user < 20; user++)         //遍历所有的用户
                {
                    if (users.ContainsKey(user))              //如果用户已经登录
                    {
                        //输出用户在线时长，并将用户在线时长延长1秒
                        Console.WriteLine("{0}号用户在线时长为{1}秒", user, users[user]++);
                    }
                }
            }
        }
    }
}
