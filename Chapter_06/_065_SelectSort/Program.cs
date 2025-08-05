using StudentSpace;

namespace _065_SelectSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            Student temp;
            int max = 0;
            for (int i = 0; i < 20; i++)
            {
                // 从未排序部分开始，将未排序部分最大的直接放在第一个，相当于把未排序部分中的最大值放到已排序部分的末尾，然后索引后移
                // 先假设未排序部分第一个是最大的
                max = i;
                for (int j = i + 1; j < 20; j++)
                {
                    if (students[j].Result > students[max].Result) max = j;//求成绩最好的学生索引
                }
                //将成绩最好的学生与索引i（未排序部分第一个）的学生交换
                temp = students[i];
                students[i] = students[max];
                students[max] = temp;
            }
            students.PrintStudents();
        }
    }
}
