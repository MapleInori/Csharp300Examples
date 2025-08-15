namespace _047_DatetimeFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime DT = DateTime.Now;
            Console.WriteLine("当前日期为：{0:d}", DT);            //当前日期为：2025 / 6 / 23
            Console.WriteLine("当前日期为：{0:D}", DT);            //当前日期为：2025年6月23日
            Console.WriteLine("当前时间为：{0:t}", DT);            //当前时间为：15:20
            Console.WriteLine("当前时间为：{0:T}", DT);            //当前时间为：15:20:36
            Console.WriteLine("当前日期时间为：{0:f}", DT);            //当前日期时间为：2025年6月23日 15:20
            Console.WriteLine("当前日期时间为：{0:F}", DT);            //当前日期时间为：2025年6月23日 15:20:36
            Console.WriteLine("当前日期时间为：{0:g}", DT);            //当前日期时间为：2025 / 6 / 23 15:20
            Console.WriteLine("当前日期时间为：{0:G}", DT);            //当前日期时间为：2025 / 6 / 23 15:20:36
            Console.WriteLine("当前月日为：{0:M}", DT);            //当前月日为：6月23日
            Console.WriteLine("当前年月为：{0:Y}", DT);            //当前年月为：2025年6月
            Console.WriteLine("当前日期为：{0:yy年MM月dd日}", DT);            //当前日期为：25年06月23日
            Console.WriteLine("当前日期为：{0:yyyy年MMMMdd日dddd }", DT);            //当前日期为：2025年六月23日星期一
            Console.WriteLine("当前时间为：{0:ttHH点mm分ss秒}", DT);            //当前时间为：下午15点20分36秒
        }
    }
}
