namespace _013_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int Number = int.Parse(Console.ReadLine());         //从控制台输入一个十进制整数
            Console.WriteLine("{0}的十六进制形式为0x{1:X8}", Number, Number);

            int NumberHex = Number & 0x000000FF;            //将数值与0xFF按位与运算
            Console.WriteLine("第1个字节为：0x{0:X2}", NumberHex); //十六进制输出第1字节
            NumberHex = Number >> 8 & 0x000000FF;           //将数值右移8位与0xFF按位与运算
            Console.WriteLine("第2个字节为：0x{0:X2}", NumberHex); //十六进制输出第2字节
            NumberHex = Number >> 16 & 0x000000FF;          //将数值右移16位与0xFF按位与运算
            Console.WriteLine("第3个字节为：0x{0:X2}", NumberHex); //十六进制输出第3字节
            NumberHex = Number >> 24 & 0x000000FF;          //将数值右移24位与0xFF按位与运算
            Console.WriteLine("第4个字节为：0x{0:X2}", NumberHex); //十六进制输出第4字节

            // 与运算将输入的整数和0xFF的二进制形式进行按位与操作，0xFF的二进制形式为00000000 00000000 00000000 11111111，
            // 由于0xFF的特性，只保留了最低的八位，前24位与0进行与操作被清空，最低八位被保留
            // 每次与后保留最低八位，然后不断右移8位，取到第二字节，第三字节和第四字节的值
            // 然后将每个字节的值以十六进制形式输出，格式化为两位数

            /*
             请输入一个整数：
            10
            10的十六进制形式为0x0000000A
            第1个字节为：0x0A
            第2个字节为：0x00
            第3个字节为：0x00
            第4个字节为：0x00
             */
        }
    }
}
