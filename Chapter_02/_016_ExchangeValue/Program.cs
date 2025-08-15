namespace _016_ExchangeValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            int number2 = int.Parse(Console.ReadLine());
            Exchange(ref number1, ref number2);
            Console.WriteLine("将两个数进行交换...");
            Console.WriteLine("第一个数等于：{0} 第二个数等于：{1}", number1, number2);
        }
        static void Exchange(ref int number1, ref int number2)
        {
            //int temp = number2;                     //将第二个数存放到临时变量中
            //number2 = number1;                      //将第一个数的值赋给第二个数
            //number1 = temp;                         //将临时变量赋值给第一个数
            number1 = number1 + number2;    // num1为两数之和
            number2 = number1 - number2;    // num2为两数之和减去num2，得到原来的num1
            number1 = number1 - number2;    // num1为两数之和减去新的num2，相当于减去num1，得到原来的num2
        }
    }
}
