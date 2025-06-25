using System.Text.RegularExpressions;

namespace _052_CheckIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =                                //正则表达式字符串
                @"^((2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)\.){3}(2[5][0-5]|2[0-4][0-9]|1\d{2}|[1-9]?\d)$";
            Regex regex = new Regex(pattern);               //创建正则表达式对象
            Console.WriteLine("请输入IP地址：");
            while (!regex.IsMatch(Console.ReadLine()))     //判断IP地址格式是否正确
            {
                Console.WriteLine("IP地址格式错误！");
                Console.WriteLine("请输入IP地址：");
            }
            Console.WriteLine("IP地址格式正确！");
        }
    }
}
