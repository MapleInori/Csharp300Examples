namespace _029_EachCharInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string String = Console.ReadLine();    //从控制台读取字符串
            foreach (char c in String)
            {
                Console.WriteLine(c);               //输出字符c
            }
        }
    }
}
