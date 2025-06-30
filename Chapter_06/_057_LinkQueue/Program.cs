namespace _057_LinkQueue
{
    class NumberNode
    {
        public int Number { get; set; }                      //数据
        public NumberNode Next { get; set; }                 //下一节点
        public NumberNode(int number, NumberNode next)
        {
            this.Number = number;
            this.Next = next;
        }
    }
    class NumberStack
    {
        private NumberNode top;                              //栈顶
        public void Push(int number)                         //进栈
        {
            if (top == null) top = new NumberNode(number, null);//创建栈顶节点
            else top = new NumberNode(number, top);
        }
        public int? Pop()                                    //出栈
        {
            if (this.top == null) return null;
            else
            {
                int number = top.Number;
                top = top.Next;
                return number;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个十进制正整数：");
            int number = int.Parse(Console.ReadLine());
            NumberStack stack = new NumberStack();              //创建数字链栈
            while (number > 0)
            {
                stack.Push(number % 8);                          //八进制低位先进栈
                number /= 8;
            }
            int? bit = stack.Pop();                             //八进制高位先出栈
            while (bit != null)
            {
                Console.Write(bit);
                bit = stack.Pop();                               //八进制高位先出栈
            }
        }
    }
}
