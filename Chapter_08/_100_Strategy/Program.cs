namespace _100_Strategy
{
    public class Orchard
    {
        Fruit fruit;                                     //水果类引用
        public Orchard(Fruit fruit)
        {
            this.fruit = fruit;
        }
        public void Plant()                              //果园种植水果
        {
            fruit.Plant();
        }
    }
    //抽象水果类
    public abstract class Fruit
    {
        public abstract void Plant();                    //抽象种植方法
    }
    //苹果类
    public class Apple : Fruit
    {
        public override void Plant()                     //种植苹果
        {
            Console.WriteLine("种植苹果！");
        }
    }
    //橘子类
    public class Orange : Fruit
    {
        public override void Plant()                     //种植橘子
        {
            Console.WriteLine("种植橘子！");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Orchard appleOrchard = new Orchard(new Apple());    //创建苹果园实例
            appleOrchard.Plant();                               //种植苹果
            Orchard orangeOrchard = new Orchard(new Orange());  //创建橘子园实例
            orangeOrchard.Plant();                              //种植橘子
        }
    }
}
