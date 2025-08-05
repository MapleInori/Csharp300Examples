using StudentSpace;
namespace _067_RadixSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentLinkList students = new StudentLinkList(100); //创建含有100个元素的学生信息链表
            StudentQueue[] studentsResult = new StudentQueue[101]; //创建成绩队列列表
            StudentNode node;
            node = students.Head;
            while (node != null)                            //将学生按成绩映射到指定索引的队列中
            {
                if (studentsResult[node.Student.Result] == null)
                    studentsResult[node.Student.Result] = new StudentQueue();
                studentsResult[node.Student.Result].In(node.Student);
                node = node.Next;
            }
            StudentNode head = null, rear = null;
            for (int i = 100; i >= 0; i--)                  //将队列按索引从小到大首尾相连
            {
                if (studentsResult[i] != null)
                {
                    if (head == null) head = studentsResult[i].Front; //第一个不为空的队列
                    else rear.Next = studentsResult[i].Front;
                    rear = studentsResult[i].Rear;           //标记队尾
                }
                StudentQueue[] studentsGrade = new StudentQueue[5]; //创建年级队列列表
                node = head;
                while (node != null)                            //将学生按年级映射到指定索引的队列中
                {
                    if (studentsGrade[node.Student.Grade] == null)
                        studentsGrade[node.Student.Grade] = new StudentQueue();
                    studentsGrade[node.Student.Grade].In(node.Student);
                    node = node.Next;
                }
                head = null; rear = null;
                for (int j = 4; j >= 1; j--)                    //将队列按索引从小到大首尾相连
                {
                    if (studentsGrade[j] != null)
                    {
                        if (head == null) head = studentsGrade[j].Front;  //第一个不为空的队列
                        else rear.Next = studentsGrade[j].Front;
                        rear = studentsGrade[j].Rear;            //标记队尾
                    }
                }
            }
        }
    }
}
