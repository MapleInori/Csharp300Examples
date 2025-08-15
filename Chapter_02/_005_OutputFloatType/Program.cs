namespace _005_OutputFloatType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Float = 123.456789f;                              //单精度浮点型
            double Double = 123.456789123456789d;                   //双精度浮点型
            decimal Decimal = 123.456789123456789123456789m;        //高精度浮点型
            Console.WriteLine("单精度浮点型\t{0}", Float);
            Console.WriteLine("双精度浮点型\t{0}", Double);
            Console.WriteLine("高精度浮点型\t{0}", Decimal);
        }
    }
}
