namespace _087_Delegate
{
    delegate void DisplayStudent(Student student);          //显示学生信息委托
    struct Student
    {
        public int Number;                               //学号
        public string Name;                              //姓名
        public string Sex;                               //性别
    }
    class StudentTable
    {
        Student[] students;                              //学生信息列表
        public StudentTable()
        {
            students = new Student[8];                    //创建学生信息表
            students[0] = new Student() { Number = 20120001, Name = "张三", Sex = "男" };
            students[1] = new Student() { Number = 20120002, Name = "李四", Sex = "女" };
            students[2] = new Student() { Number = 20120003, Name = "王五", Sex = "男" };
            students[3] = new Student() { Number = 20120004, Name = "赵六", Sex = "女" };
            students[4] = new Student() { Number = 20120005, Name = "钱七", Sex = "男" };
            students[5] = new Student() { Number = 20120006, Name = "孙三", Sex = "女" };
        }

        public void Display(DisplayStudent displayCallback) //显示学生信息
        {
            foreach (Student student in students) displayCallback(student);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentTable table = new StudentTable();
            table.Display(DisplayCallback);                     //显示表中所有男生的信息
        }
        static void DisplayCallback(Student student)
        {
            if (student.Sex == "男")
                Console.WriteLine("学号：{0}\t姓名:{1}\t性别：{2}",
                    student.Number, student.Name, student.Sex);
        }
    }
}
