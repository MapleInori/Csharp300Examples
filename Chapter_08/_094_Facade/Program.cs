namespace _094_Facade
{
    //苹果类
    public class Apple
    {
        public void PlantApple()                    //种植苹果树
        {
            Console.WriteLine("种植苹果树！");
        }
    }
    //橘子类
    public class Orange
    {
        public void PlantOrange()                   //种植橘子树
        {
            Console.WriteLine("种植橘子树！");
        }
    }
    //香蕉类
    public class Banana
    {
        public void PlantBanana()                   //种植香蕉树
        {
            Console.WriteLine("种植香蕉树！");
        }
    }
    public class Plant
    {
        Apple apple = new Apple();                  //创建苹果类
        Orange orange = new Orange();               //创建橘子类
        Banana banana = new Banana();               //创建香蕉类
        public void PlantAppleOrange()
        {
            Console.WriteLine("------北京果园------");
            apple.PlantApple();                      //种植苹果树
            orange.PlantOrange();                    //种植橘子树
        }
        public void PlantOrangeBanana()
        {
            Console.WriteLine("------上海果园------");
            orange.PlantOrange();                    //种植橘子树
            banana.PlantBanana();                    //种植香蕉树
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant();
            plant.PlantAppleOrange();                       //北京果园种植苹果和橘子
            plant.PlantOrangeBanana();                     //上海果园种植橘子和香蕉
        }
    }
}
