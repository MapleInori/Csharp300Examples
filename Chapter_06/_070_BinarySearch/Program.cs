using StudentSpace;

namespace _070_BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            int number;
            Console.WriteLine("请输入要查询的学生学号：");
            if (!int.TryParse(Console.ReadLine(), out number)) number = 0;
            int middle = 0;                                 //用于查找的对象索引
            int low = 0;                                    //查找区域索引下限
            int high = 19;                                  //查找区域索引上限
            int flag = -1;                         //用于标记查找成功时的索引，如果查找失败，则为-1
            while (low <= high)                     //折半查找学生指定学生信息
            {
                middle = (low + high) / 2;
                if (number > students[middle].Number) low = middle + 1; //下一次在右半区域中查找
                else if (number < students[middle].Number) high = middle - 1; //下一次在左半区域中查找
                else
                {
                    flag = middle;                   //查找成功，将记录索引存入flag中
                    break;                           //跳出查找循环
                }
            }
            if (flag > 0)                          //查找成功
                Console.WriteLine("姓名：{0}\t年级：{1}\t成绩：{2}",
                    students[flag].Name, students[flag].Grade, students[flag].Result);
            else Console.WriteLine("无此学生信息！");//查找失败
        }
    }
}
