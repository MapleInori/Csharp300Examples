namespace _090_AbstractFactory
{
    //抽象苹果类
    public abstract class Apple
    {
        public abstract void PlantApple();               //抽象苹果种植方法
    }
    //北京苹果类
    public class BJApple : Apple
    {
        public override void PlantApple()                //北京苹果种植方法
        {
            Console.WriteLine("种植又红又粉的北京苹果！");
        }
    }
    //上海苹果类
    public class SHApple : Apple
    {
        public override void PlantApple()                //上海苹果种植方法
        {
            Console.WriteLine("种植又青又脆的上海苹果！");
        }
    }
    //抽象橘子类
    public abstract class Orange
    {
        public abstract void PlantOrange();              //抽象橘子种植方法
    }
    //北京橘子类
    public class BJOrange : Orange
    {
        public override void PlantOrange()               //北京橘子种植方法
        {
            Console.WriteLine("种植又大又圆的北京橘子！");
        }
    }
    //上海橘子类
    public class SHOrange : Orange
    {
        public override void PlantOrange()               //上海橘子种植方法
        {
            Console.WriteLine("种植又酸又甜的上海橘子！");
        }
    }
    //抽象果园类
    public abstract class Orchard
    {
        public abstract Apple CreateApple();             //抽象创建苹果方法
        public abstract Orange CreateOrange();           //抽象创建橘子方法
    }
    //北京果园类
    public class BJOrchard : Orchard
    {
        public override Apple CreateApple()
        {
            return new BJApple();                    //创建北京苹果
        }
        public override Orange CreateOrange()
        {
            return new BJOrange();                   //创建北京橘子
        }
    }
    //上海果园类
    public class SHOrchard : Orchard
    {
        public override Apple CreateApple()
        {
            return new SHApple();                    //创建上海苹果
        }
        public override Orange CreateOrange()
        {
            return new SHOrange();                   //创建上海橘子
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Orchard bjFruitFactory = new BJOrchard();           //创建北京果园实例
            Apple bjApple = bjFruitFactory.CreateApple();       //北京果园创建北京苹果
            Orange bjOrange = bjFruitFactory.CreateOrange();    //北京果园创建北京橘子
            bjApple.PlantApple();                               //北京果园种植北京苹果
            bjOrange.PlantOrange();                             //北京果园种植北京橘子
            Orchard shFruitFactory = new SHOrchard();           //创建上海果园实例
            Apple shApple = shFruitFactory.CreateApple();       //上海果园创建上海苹果
            Orange shOrange = shFruitFactory.CreateOrange();    //上海果园创建上海橘子
            shApple.PlantApple();                               //上海果园种植上海苹果
            shOrange.PlantOrange();                             //上海果园种植上海橘子
        }
    }
}
