using StudentSpace;

namespace _069_SequenceSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            string name;
            Console.WriteLine("请输入要查询的学生姓名：");
            name = Console.ReadLine();
            int i = 0, count = 0;
            for (; i < 20; i++)                             //顺序查找指定学生的信息
            {
                if (students[i].Name == name)
                {
                    Console.WriteLine("学号：{0}\t年级：{1}\t成绩：{2}",
                        students[i].Number, students[i].Grade, students[i].Result);
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("无此学生信息！");
        }
    }
}
