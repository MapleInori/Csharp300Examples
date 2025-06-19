namespace _007_UseEnumType
{
    enum Animal : byte
    {
        Dog = 0,                                    //狗
        Cat = 1,                                    //猫
        Mouse = 2                                   //鼠
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Cat;                     //为枚举型变量赋值
            switch (animal)                                 //判断枚举型变量的值
            {
                case Animal.Dog:                            //如果为Dog，则输出“狗”
                    Console.WriteLine("狗");
                    break;
                case Animal.Cat:                            //如果为Cat，则输出“猫”
                    Console.WriteLine("猫");
                    break;
                case Animal.Mouse:                          //如果为Mouse，则输出“鼠”
                    Console.WriteLine("鼠");
                    break;
                default:
                    break;
            }
        }
    }
}
