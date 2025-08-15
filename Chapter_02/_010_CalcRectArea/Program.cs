namespace _010_CalcRectArea
{
    class Rectangle
    {
        public int Width, Height;                        // 声明整型变量表示矩形的宽和高
        public int TryArea()                             // 计算矩形面积并检测数据溢出
        {
            checked
            {
                int area = Width * Height;
                return area;
            }
        }
        public int Area() { return Width * Height; }     // 计算矩形面积
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();               // 创建矩形实例
            Console.WriteLine("请输入矩形宽度：");
            rect.Width = int.Parse(Console.ReadLine());    // 从控制台输入数据给矩形的宽赋值
            Console.WriteLine("请输入矩形高度：");
            rect.Height = int.Parse(Console.ReadLine());   // 从控制台输入数据给矩形的高赋值
            // Area直接计算矩形面积，并不会检测计算出的面积是否发生数据溢出
            Console.WriteLine("矩形面积为：\n{0}", rect.Area());
            // TryArea方法中在计算矩形面积时使用了checked关键字，该关键字用于检测运行时变量数据溢出，如果发生溢出程序，则会抛出异常
            Console.WriteLine("矩形面积为：\n{0}", rect.TryArea());

        }
    }
}
