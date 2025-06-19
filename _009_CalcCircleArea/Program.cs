namespace _009_CalcCircleArea
{
    class Circle
    {
        const double PI = 3.1415926f;                            //圆周率
        public readonly int Radius = 1;                          //半径
        public Circle(int radius) { Radius = radius; }           //构造函数
        public Circle() { }                                    //默认构造函数
        public double Area() { return PI * Radius * Radius; }    //计算圆形面积
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);                    //创建一个半径为10的圆形实例
            Console.WriteLine("半径为{0}的圆形面积为{1}", circle.Radius, circle.Area());//输出圆形面积
            Circle circle2 = new Circle();
            Console.WriteLine("半径为{0}的圆形面积为{1}", circle2.Radius, circle2.Area());//输出圆形面积
        }
    }
}
