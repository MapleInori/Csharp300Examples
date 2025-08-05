using StudentSpace;

namespace _072_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            StudentNode[] hashTable = new StudentNode[5];   // 哈希表长度为5，每个位置存储链表，链式处理哈希冲突
            for (int i = 0; i < 20; i++)
            {
                int index = students[i].Result % 5;                  //计算哈希地址
                if (hashTable[index] == null) hashTable[index] = new StudentNode(students[i], null);
                else hashTable[index] = new StudentNode(students[i], hashTable[index]); // 头插
            }
            int result;
            Console.WriteLine("请输入要查询的学生的成绩：");
            if (!int.TryParse(Console.ReadLine(), out result)) Console.WriteLine("输入有误!");
            bool successful = false;                            //标记查找是否成功
            StudentNode node = hashTable[result % 5];           //计算哈希地址
            while (node != null)
    {
                if (node.Student.Result == result)               //查找成功
                {
                    Console.WriteLine("学号：{0}\t姓名：{1}\t年级：{2}",
                        node.Student.Number, node.Student.Name, node.Student.Grade);
                    successful = true;
                }
                node = node.Next;
            }
            if (!successful) Console.WriteLine("无此学生信息!"); //查找失败
        }
    }
}
