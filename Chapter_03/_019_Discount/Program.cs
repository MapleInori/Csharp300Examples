namespace _019_Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入商品价格：");
            decimal price = decimal.Parse(Console.ReadLine());      //商品价格

            if (price >= 100)                               //价格满100元打9.5折
            {
                price *= 0.95m;
            }
            // {0:C2}是对{0}参数的格式化，C2表示货币格式，保留两位小数
            Console.WriteLine("应付金额{0:C2}", price);
        }
    }
}
