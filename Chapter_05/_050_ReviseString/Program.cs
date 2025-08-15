namespace _050_ReviseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《暮江吟》");
            string poetryRight = "一道残阳铺水中，半江瑟瑟半江红。可怜九月初三夜，露似珍珠月似弓。";
            string poetryWrong = "一道阳光铺水中，半江瑟瑟半江红。可怜九月初三夜晚，露像珍珠月像弓。";
            do
            {
                Console.WriteLine(poetryWrong);                      //输出错误的古诗
                Console.WriteLine("请输入功能：删除，替换");
                string function = Console.ReadLine();
                switch (function)                                    //选择功能
                {
                    case "删除":
                        Console.Write("请输入从第几个字开始删除：");
                        int start = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("请输入删除的字符串长度：");
                        int lenght = int.Parse(Console.ReadLine());
                        poetryWrong = poetryWrong.Remove(start, lenght);//移除古诗中指定的字符
                        break;
                    case "替换":
                        Console.Write("请输入需要替换的字符串：");
                        string oldValue = Console.ReadLine();
                        Console.Write("请输入替换后的字符串：");
                        string newValue = Console.ReadLine();
                        poetryWrong = poetryWrong.Replace(oldValue, newValue);  //替换古诗中错误的字符
                        break;
                    default:
                        Console.WriteLine("功能错误！");
                        break;
                }
            } while (poetryRight != poetryWrong);
            Console.WriteLine(poetryRight);                     //输出正确的古诗
            Console.WriteLine("修改成功！");
        }
    }
}
