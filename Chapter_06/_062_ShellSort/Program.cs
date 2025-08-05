namespace _062_ShellSort
{
    public struct Student
    {
        static readonly string[] LastNames =                 //姓列表
          new string[] { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
        static readonly string[] FirstNames =                //名列表
          new string[] { "一", "二", "三", "四", "五", "六", "七", "八" };
        static readonly Random R = new Random();
        public readonly string Name;                         //姓名
        public readonly int Number;                          //学号
        public readonly int Grade;                           //年级
        public readonly int Result;                          //成绩
        public Student(int number)
        {
            this.Name = LastNames[R.Next(LastNames.Length)]   //随机生成姓
                              + FirstNames[R.Next(FirstNames.Length)];       //随机生成名
            this.Number = number;
            this.Grade = R.Next(1, 5);                         //随机生成年级
            this.Result = R.Next(101);                        //随机生成分数
        }
    }
    public class StudentList
    {
        private Student[] Students;                          //学生信息顺序表
        //检索学生信息表
        public Student this[int index]
        {
            get { return Students[index]; }
            set { Students[index] = value; }
        }
        public StudentList(int count)
        {
            this.Students = new Student[count];               //创建学生信息表
                                                              //为学生信息表添加学生信息
            for (int i = 0; i < count; i++)
            {
                this.Students[i] = new Student(20120001 + i);
            }
        }
        public int Length { get { return Students.Length; } }//顺序表长度
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);

            Console.WriteLine("排序前的学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}",
                  students[i].Number, students[i].Name, students[i].Result);
            }

            for (int increment = 5; increment > 0; increment--)
            {
                //遍历索引从increment开始的学生信息
                for (int i = increment; i < 20; i++)
                {
                    //如果索引为i的学生成绩大于索引为i-increment的学生成绩
                    //则前i/increment+1个学生成绩已经有序
                    if (students[i].Result > students[i - increment].Result)
                    {
                        Student temp = students[i];
                        int j = i - increment;
                        //将索引为i的学生信息插入到其所在分组中合适的位置
                        for (; j >= 0 && temp.Result > students[j].Result; j -= increment)
                        {
                            students[j + increment] = students[j];
                        }
                        students[j + increment] = temp;
                    }
                }
            }

            Console.WriteLine("排序后的学生信息表：");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}",
                  students[i].Number, students[i].Name, students[i].Result);
            }
        }
    }
}
