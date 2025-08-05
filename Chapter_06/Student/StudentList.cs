namespace StudentSpace
{
    /// <summary>
    /// 学生结构体
    /// </summary>
    public struct Student
    {
        static readonly string[] LastNames = new string[] { "赵", "钱", "孙", "李", "周", "吴", "郑", "王" };
        static readonly string[] FirstNames = new string[] { "一", "二", "三", "四", "五", "六", "七", "八" };
        static readonly Random R = new Random();
        public readonly string Name;                         // 姓名  
        public readonly int Number;                          // 学号  
        public readonly int Grade;                           // 年级  
        public readonly int Result;                          // 成绩  

        // 修复 CS8862 错误：添加 this() 构造函数初始化表达式  
        public Student(int number) : this()
        {
            this.Name = LastNames[R.Next(LastNames.Length)]   // 随机生成姓  
                              + FirstNames[R.Next(FirstNames.Length)];       // 随机生成名  
            this.Number = number;
            this.Grade = R.Next(1, 5);                         // 随机生成年级  
            this.Result = R.Next(101);                        // 随机生成分数  
        }
    }
    /// <summary>
    /// 学生列表
    /// </summary>
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
                this.Students[i] = new Student(20250001 + i);
            }
            Console.WriteLine("排序前的学生信息表：");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}",
                  this.Students[i].Number, this.Students[i].Name, this.Students[i].Result);
            }
        }

        public int Length { get { return Students.Length; } }//顺序表长度

        public void PrintStudents()
        {
            Console.WriteLine("学生列表信息");
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("学号：{0}\t姓名：{1}\t成绩：{2}",
                  this.Students[i].Number, this.Students[i].Name, this.Students[i].Result);
            }
        }
    }
    /// <summary>
    /// 学生节点
    /// </summary>
    public class StudentNode
    {
        public Student Student { get; set; }             //学生信息
        public StudentNode Next { get; set; }            //下一节点类实例
        public StudentNode(Student student, StudentNode next)
        {
            this.Student = student;
            this.Next = next;
        }
    }
    /// <summary>
    /// 学生链表
    /// </summary>
    public class StudentLinkList
    {
        public StudentNode Head { get; set; }            //链表头节点
        public StudentLinkList(int count)
        {
            Head = new StudentNode(new Student(20250000 + count), null);
            for (int i = count - 1; i > 0; i--)              //头插法建表
            {
                //创建新节点，将原头节点作为新节点的下一节点，将新节点作为头节点
                Head = new StudentNode(new Student(20250000 + i), Head);
            }
        }
    }
    /// <summary>
    /// 学生队列
    /// </summary>
    public class StudentQueue
    {
        public StudentNode Front { get; private set; }       //队头
        public StudentNode Rear { get; private set; }        //队尾
        public void In(Student student)                      //进队
        {
            if (Rear == null)
            {
                Rear = new StudentNode(student, null);         //创建队尾节点
                Front = Rear;
            }
            else
            {
                Rear.Next = new StudentNode(student, null);
                Rear = Rear.Next;
            }
        }
        public Student? Out()                                //出队
        {
            if (Front == null) return null;
            Student student = Front.Student;
            Front = Front.Next;
            if (Front == null) Rear = null;
            return student;
        }
    }
}