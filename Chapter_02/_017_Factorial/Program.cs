namespace _017_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}的阶乘为{1}", number, Factorial(number));
        }

        /// 计算n的阶乘
        /// <param name="n">需要计算阶乘的正整数</param>
        /// <returns>n的阶乘</returns>
        static decimal Factorial(decimal n)
        {
            if (n == 1) return 1;                   //将1作为函数返回值
            else return n * Factorial(n - 1);       //计算n乘以n-1的阶乘，并作为参数返回值
        }
    }
}
