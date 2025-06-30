namespace _056_LinkList
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

    public class StudentLinkList
    {
        public StudentNode Head { get; set; }            //链表头节点
        public StudentLinkList(int count)
        {
            Head = new StudentNode(new Student(20120000 + count), null);
            for (int i = count - 1; i > 0; i--)              //头插法建表
            {
                //创建新节点，将原头节点作为新节点的下一节点，将新节点作为头节点
                Head = new StudentNode(new Student(20120000 + i), Head);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentLinkList list1 = new StudentLinkList(5);   //创建含有5个元素的学生信息链表
            StudentNode node1 = list1.Head;                 //学生信息表1的头节点设为当前节点
            Console.WriteLine("输出学生信息表1：");
            while (node1 != null)
            {
                Console.Write(node1.Student.Name + "\t");
                node1 = node1.Next;                         //将下一节点设置为当前节点
            }
            Console.WriteLine("\n\n输出学生信息表2：");
            StudentLinkList list2 = new StudentLinkList(5);   //创建含有5个元素的学生信息链表
            StudentNode node2 = list2.Head;                 //学生信息表2的头节点设为当前节点
            while (node2 != null)
            {
                Console.Write(node2.Student.Name + "\t");
                node2 = node2.Next;                         //将下一节点设置为当前节点
            }
            node1 = list1.Head;                    //重置表1当前节点
            node2 = list2.Head;                    //重置表2当前节点
                                                   //将学生信息表2合并到学生信息表1中
            while (node1 != null && node2 != null)
            {
                list2.Head = node2.Next;            //将表2当前节点从表2中删除
                node2.Next = node1.Next;            //将表1当前节点的后续节点拼接到表2当前节点的后边
                node1.Next = node2;                 //将表2当前节点作为表1当前节点的下一节点
                node1 = node2.Next;                 //表1当前节点指向表2当前节点的下一节点（也是原来表1的下一个节点，是合并表2节点后的往后第二个节点）
                node2 = list2.Head;                 //表2当前节点指向表2的头节点
            }
            Console.WriteLine("\n\n输出合并后的学生信息表1：");
            node1 = list1.Head;
            while (node1 != null)                  //输出所有的节点
            {
                Console.Write(node1.Student.Name + "\t");
                node1 = node1.Next;
            }
        }
    }
}
