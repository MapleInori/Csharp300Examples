using StudentSpace;
namespace _066_HeapSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            Student temp;
            for (int i = 19; i >= 1; i--)           //将建堆后的根节点与索引为i的节点交换
            {
                CreateHeap(students, i);
                temp = students[0];
                students[0] = students[i];
                students[i] = temp;
            }
        }
        static void CreateHeap(StudentList students, int n)
        {
            //从第一个非叶子节点开始遍历
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                int lChild = i * 2 + 1;                       //左孩子索引
                int rChild = i * 2 + 2;                       //右孩子索引
                int max = i;                                  //最大值索引
                                                              //将节点i的学生成绩与其左孩子节点的学生成绩进行比较
                if (students[lChild].Result > students[max].Result) max = lChild;
                //将节点i的学生成绩与其右孩子节点的学生成绩进行比较
                if (rChild <= n && students[rChild].Result > students[max].Result) max = rChild;
                //将成绩最好的节点调整到索引为i的节点上
                if (max != i)
                {
                    Student temp = students[i];
                    students[i] = students[max];
                    students[max] = temp;
                }
            }
        }
    }
}
