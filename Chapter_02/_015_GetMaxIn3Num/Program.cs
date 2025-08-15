namespace _015_GetMaxIn3Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            int Number1 = int.Parse(Console.ReadLine());            //从控制台输入第一个数
            Console.WriteLine("请输入第二个数：");
            int Number2 = int.Parse(Console.ReadLine());            //从控制台输入第二个数
            Console.WriteLine("请输入第三个数：");
            int Number3 = int.Parse(Console.ReadLine());            //从控制台输入第三个数

            int max = Number1 > Number3 ?   /* Num1大于Num3吗*/
                Number1 > Number2 ? Number1 : Number2 /* 如果Num1大于Num3，则继续判断Num1和Num2谁大*/
                : 
                Number3 > Number2 ? Number3 : Number2;/* 如果Num1小于Num3，则继续判断Num3和Num2谁大*/
            Console.WriteLine("{0} {1} {2}中最大值为{3}", Number1, Number2, Number3, max);
        }
    }
}
