namespace _020_CheckChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串:");
            string str = Console.ReadLine();

            foreach (var ch in str)
            {
                // 这里的比较是基于字符的ASCII码值进行的判断，也可以使用char.IsLower,char.IsUpper,char.IsDigit等方法来判断字符类型
                if (ch >= 'a' && ch <= 'z')                        //判断是否为小写字母
                {
                    Console.WriteLine("{0} 是小写字母", ch);
                }
                else if (ch >= 'A' && ch <= 'Z')                   //判断是否为大写字母
                {
                    Console.WriteLine("{0} 是大写字母", ch);
                }
                else if (ch >= '0' && ch <= '9')                   //判断是否为十进制数字
                {
                    Console.WriteLine("{0} 是十进制数字", ch);
                }
                else
                {
                    Console.WriteLine("{0} 是其他字符", ch);
                }
            }
        }
    }
}
