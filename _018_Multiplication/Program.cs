namespace _018_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第三个数：");
            int number3 = int.Parse(Console.ReadLine());


            // 在静态方法中，不能直接调用非静态方法，因为非静态方法属于类的实例，而静态方法属于类本身。
            Program p = new Program();
            int result;                                     //存储三个数相乘的结果
            p.GetMultResult(out result, number1, number2, number3);
            Console.WriteLine("{0} * {1} * {2} = {3}", number1, number2, number3, result);
        }

        /// 求多个整数的乘积
        /// <param name="result">多个整数的乘积</param>
        /// <param name="numbers">需要求乘积的整数集合</param>
        public void GetMultResult(out int result, params int[] numbers)
        {
            result = 1;                                          //初始值为1
            foreach (int number in numbers) result *= number;    //计算多个整数乘积
        }
    }
}
