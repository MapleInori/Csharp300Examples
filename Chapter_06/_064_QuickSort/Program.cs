using StudentSpace;

namespace _064_QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            int low = 0, high = 19;
            int result = 60;                                //合格的成绩
            Student temp = students[low];
            //第一趟快速排序，将学生按成绩分为大于或等于60分的和小于60分的两部分
            while (low < high)
            {
                while (low < high && students[high].Result >= result) high--;
                students[low++] = students[high];
                while (low < high && students[low].Result <= result) low++;
                students[high--] = students[low];
            }
            students[low] = temp;
            if (temp.Result < result) low++;
            students.PrintStudents();
            Console.WriteLine(students[low].Result);
        }
    }
}
