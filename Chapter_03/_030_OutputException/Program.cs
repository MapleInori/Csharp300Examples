namespace _030_OutputException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //从控制台输入一个整数，如果该整数不在0到100的范围内，则抛出异常提示数值不在正确范围内，
            //如果输入的不是整数，则会捕获系统抛出字符串格式不正确的提示。
            //当捕获取异常时，程序又重新提示用户输入一个整数，直到输入正确的整数为止

            int number = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("请输入一个整数：");
                    number = int.Parse(Console.ReadLine());  //当输入的不是整数时抛出异常
                    if (number < 0 || number > 100)           //当数值不在0到100之间时抛出异常
                        throw new ArgumentOutOfRangeException("number", "数值应该在100以内");
                }
                catch (ArgumentOutOfRangeException e)       //捕获“数据不在指定范围”异常
                {
                    Console.WriteLine(e.Message);            //输出异常消息的内容
                    continue;                                //重新输入整数
                }
                catch (FormatException e)                   //捕获“字符串格式不正确”异常
                {
                    Console.WriteLine(e.Message);            //输出异常消息的内容
                    number = 100;                            //数值取最大值
                    continue;                                //重新输入整数
                }
                finally
                {
                    Console.WriteLine("输入整数为{0}", number);  //输出数值
                }
                break;
            }
        }
    }
}
