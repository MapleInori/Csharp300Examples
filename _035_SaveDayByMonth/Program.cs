namespace _035_SaveDayByMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份：");
            int year = int.Parse(Console.ReadLine());
            byte[][] months = new byte[12][];
            for (int month = 0; month < 12; month++)
            {
                if (month < 7)  // indenx 0,1,2,3,4,5,6 = 1,2,3,4,5,6,7月
                {
                    //一月、三月、五月、七月为大月，每月有31天
                    if (month % 2 == 0) months[month] = new byte[31];
                    else if (month == 1)    // index = 1 是 2月
                    {//二月闰年为29天，否则为28天
                        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                            months[month] = new byte[29];
                        else
                            months[month] = new byte[30];
                    }   // index 3，5 是 四，六月
                    else months[month] = new byte[30];       //四月、六月为小月，每月30天
                }
                else  // index 7,8,9,10,11 = 8,9,10,11,12月
                {
                    // 9,11月为30天，index = 8，10
                    if (month % 2 == 0) months[month] = new byte[30]; //九月、十一月为小月，30天
                    // 8，10，12月为31天，index = 7，9，11
                    else months[month] = new byte[31];       //八月、十月、十二月为大月，每月31天
                }
            }
            //遍历月份
            for (int month = 0; month < 12; month++)
            {
                Console.WriteLine("{0}月：", month + 1);
                //遍历日期
                for (int day = 0; day < months[month].Length; day++)
                {
                    months[month][day] = (byte)(day + 1);
                    Console.Write("{0}日", months[month][day]);
                }
                Console.WriteLine();
            }
        }
    }
}
