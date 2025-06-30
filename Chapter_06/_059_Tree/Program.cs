namespace _059_Tree
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
    class StudentNode
    {
        public readonly Student Student;                 //学生信息
        public StudentNode LeftChild { get; set; }       //左孩子节点
        public StudentNode RightChild { get; set; }      //右孩子节点
        public StudentNode(Student student)
        {
            this.Student = student;
        }
    }
    class StudentTree
    {
        public readonly StudentNode Root;                //树节点
        public static Random R = new Random();
        int count = 0;
        // 构造树并且创建节点
        public StudentTree(int count)
        {
            this.count = count;
            this.Root = CreateNode(ref count);
        }
        //创建节点及其子节点
        StudentNode CreateNode(ref int index)
        {
            // 随机决定是否创建当前节点
            if (R.Next(count) > index) return null;
            // 根节点不保存学生信息，相当于带头结点的二叉树，如果时index--，则是不带头节点的二叉树
            if (--index == 0) return null;
            StudentNode node = new StudentNode(new Student(20120000 + index));
            node.LeftChild = CreateNode(ref index);           //创建左孩子节点
            node.RightChild = CreateNode(ref index);          //创建右孩子节点
            return node;
        }
        //先序遍历
        public void PreOrder(StudentNode node)
        {
            if (node == null) return;
            Console.Write(node.Student.Name + "\t");          //输出节点
            PreOrder(node.LeftChild);                         //遍历左子树
            PreOrder(node.RightChild);                        //遍历右子树
        }
        //中序遍历
        public void InOrder(StudentNode node)
        {
            if (node == null) return;
            InOrder(node.LeftChild);                          //遍历左子树
            Console.Write(node.Student.Name + "\t");          //输出节点
            InOrder(node.RightChild);                         //遍历右子树
        }
        //后序遍历
        public void PostOrder(StudentNode node)
        {
            if (node == null) return;
            PostOrder(node.LeftChild);                        //遍历左子树
            PostOrder(node.RightChild);                       //遍历右子树
            Console.Write(node.Student.Name + "\t");          //输出节点
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentTree tree = new StudentTree(1);             //创建学生信息二叉树
            Console.WriteLine("先序遍历：");
            tree.PreOrder(tree.Root);                           //先序遍历
            Console.WriteLine("\n中序遍历：");
            tree.InOrder(tree.Root);                            //中序遍历
            Console.WriteLine("\n后序遍历：");
            tree.PostOrder(tree.Root);                          //后序遍历
        }
    }
}
