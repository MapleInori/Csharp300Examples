using StudentSpace;

namespace _071_BinarySortingTree
{
    public class BTreeNode
    {
        public Student Student { get; private set; }     //学生信息
        public BTreeNode LeftChild { get; set; }         //左孩子节点
        public BTreeNode RightChild { get; set; }        //右孩子节点
        public BTreeNode(Student student) { this.Student = student; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(20);
            BTreeNode root = new BTreeNode(students[0]);   //创建二叉排序树根节点
            for (int i = 1; i < 20; i++)
            {
                CreateBinarySortingTree(root, students[i]); //根据学生成绩创建二叉排序树
            }
        }
        //创建二叉排序树
        static void CreateBinarySortingTree(BTreeNode node, Student student)
        {
            if (student.Result < node.Student.Result)                   //如果成绩比根节点小
            {
                if (node.LeftChild == null)                             //如果左子树为空
                    node.LeftChild = new BTreeNode(student);            //创建左孩子节点，并将学生信息添加到该孩子节点中
                else                                                    //如果左子树不为空
                    CreateBinarySortingTree(node.LeftChild, student);   //将学生信息添加到左子树中
            }
            else if (student.Result > node.Student.Result)              //如果成绩比根节点大
            {
                if (node.RightChild == null)                            //如果右子树为空      
                    node.RightChild = new BTreeNode(student);           //创建右孩子节点，并将学生信息添加到该孩子节点中
                else                                                    //如果右子树不为空
                    CreateBinarySortingTree(node.RightChild, student);  //将学生信息添加到右子树中
            }
        }
    }
}
