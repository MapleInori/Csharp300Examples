namespace _001_HelloWorld   //引用系统命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello world";                  //控制台窗体标题
            Console.WriteLine("Hello world");               //在控制台窗口中输出hello world
            Console.ReadLine();                             //等待从控制台输入一行字符串
        }
    }
}
