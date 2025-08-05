namespace _063_BubbleSort
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
            for (int i = 1; i < 20; i++)
            {
                if (students[i].Result > students[i - 1].Result)     //成绩差的后移
                {
                    Student temp = students[i];
                    students[i] = students[i - 1];
                    students[i - 1] = temp;
                }
            }
            for (int i = 19; i > 0; i--)
            {
                if (students[i].Result > students[i - 1].Result)     //成绩好的前移
                {
                    Student temp = students[i];
                    students[i] = students[i - 1];
                    students[i - 1] = temp;
                }
            }
            Console.WriteLine(students[0].Name + students[0].Result);
            Console.WriteLine(students[19].Name + students[19].Result);
        }
    }
}
