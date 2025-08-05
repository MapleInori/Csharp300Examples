namespace _079_Inheritance
{
    //圆
    class Circle
    {
        protected int radius;                                    //半径
        public int Radius { get { return radius; } }             //半径
        public double Volume { get; protected set; }             //体积
    }
    //球
    class Ball : Circle
    {
        public Ball(int radius)
        {
            this.radius = radius;
            Volume = 4 * Math.PI * radius * radius * radius / 3;  //计算球体体积
        }
    }
    //圆柱
    class Cylinder : Circle
    {
        public Cylinder(int radius, int high)
        {
            this.radius = radius;
            Volume = Math.PI * radius * radius * high;            //计算圆柱体积
        }
    }
    //圆锥
    class Cone : Circle
    {
        public Cone(int radius, int high)
        {
            this.radius = radius;
            Volume = Math.PI * radius * radius * high / 3;        //计算圆锥体积
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball(10);  //实例化球体
            Console.WriteLine("半径为{0}的球体体积为{1:0.00}", ball.Radius, ball.Volume);
            Circle cylinder = new Cylinder(10, 10);   //实例化圆柱体
            Console.WriteLine("半径为{0}高度为{1}的圆柱体体积为{2:F3}", cylinder.Radius, 10,cylinder.Volume);
            Circle cone = new Cone(10, 10);  //实例化圆锥体
            Console.WriteLine("半径为{0}高度为{1}的圆柱体体积为{2:#,#.#}", cone.Radius, 10,cone.Volume);
        }
    }
}
