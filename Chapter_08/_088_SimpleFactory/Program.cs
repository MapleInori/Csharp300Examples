namespace _088_SimpleFactory
{
    //抽象水果类
    public abstract class Fruit
    {
        public abstract void Plant();                    //抽象种植方法
    }
    //具体苹果类
    public class Apple : Fruit
    {
        public override void Plant()                     //种植苹果方法
        {
            Console.WriteLine("种植苹果树！");
        }
    }
    //具体橘子类
    public class Orange : Fruit
    {
        public override void Plant()                     //种植橘子方法
        {
            Console.WriteLine("种植橘子树！");
        }
    }
    //果园类
    public class Orchard
    {
        public Fruit Create(string name)
        {
            switch (name)
            {
                case "Apple":
                    return new Apple();                //创建苹果类
                case "Orange":
                    return new Orange();               //创建橘子类
                default:
                    throw new Exception("水果名称错误！");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Orchard factory = new Orchard();                    //创建果园实例
            Fruit apple = factory.Create("Apple");              //创建苹果实例
            apple.Plant();                                      //种植苹果
            Fruit orange = factory.Create("Orange");            //创建橘子实例
            orange.Plant();                                     //种植橘子
        }
    }
}
