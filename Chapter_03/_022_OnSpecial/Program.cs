namespace _022_OnSpecial
{
    enum Week : byte
    {
        Sunday,                                      //星期日
        Monday,                                      //星期一
        Tuesday,                                    //星期二
        Wednesday,                                  //星期三
        Thursday,                                   //星期四
        Friday,                                      //星期五
        Saturday                                    //星期六
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入星期：");
            // byte.Parse() 将字符串转换为 byte 数值，(Week) 强制类型转换将 byte 值转为 Week 枚举类型
            Week week = (Week)byte.Parse(Console.ReadLine());   // 输入0123456
            switch (week)
            {
                case Week.Sunday:
                    Console.WriteLine("星期日特价菜：爆炒牛肉18元");
                    break;
                case Week.Monday:
                    Console.WriteLine("星期一特价菜：啤酒鸭26元");
                    break;
                case Week.Tuesday:
                    Console.WriteLine("星期二特价菜：红烧肉20元");
                    break;
                case Week.Wednesday:
                    Console.WriteLine("星期三特价菜：回锅肉16元");
                    break;
                case Week.Thursday:
                    Console.WriteLine("星期四特价菜：水煮鱼24元");
                    break;
                case Week.Friday:
                    Console.WriteLine("星期五特价菜：剁椒鱼头30元");
                    break;
                case Week.Saturday:
                    Console.WriteLine("星期六特价菜：手撕包菜12元");
                    break;
                default:
                    break;
            }
        }
    }
}
