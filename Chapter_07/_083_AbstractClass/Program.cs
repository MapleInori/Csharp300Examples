namespace _083_AbstractClass
{
    //抽象学生类
    abstract class Student
    {
        public abstract int Authority();                     //抽象获取权限方法
    }
    //本科生
    class Undergraduate : Student
    {
        public override int Authority() { return 5; }        //重写获取权限方法
    }
    //硕士生
    class Postgraduate : Student
    {
        public override int Authority() { return 10; }       //重写获取权限方法
    }
    //博士生
    class Doctor : Student
    {
        public override int Authority() { return 15; }       //重写获取权限方法
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Undergraduate = new Undergraduate();        //创建本科生实例
            Console.WriteLine("本科生可以借{0}本书", Undergraduate.Authority());
            Student Postgraduate = new Postgraduate();          //创建硕士生实例
            Console.WriteLine("硕士生可以借{0}本书", Postgraduate.Authority());
            Student Doctor = new Doctor();                      //创建博士生实例
            Console.WriteLine("博士生可以借{0}本书", Doctor.Authority());
        }
    }
}
