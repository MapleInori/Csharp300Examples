namespace _058_LinkStack
{
    class CharNode
    {
        public char Char { get; set; }                   //字符
        public CharNode Next { get; set; }               //下一节点
        public CharNode(char Char, CharNode next)
        {
            this.Char = Char;
            this.Next = next;
        }
    }

    class CharQueue
    {
        CharNode front;                                  //队头
        CharNode rear;                                   //队尾
        public void In(char Char)                        //进队
        {
            if (rear == null)   // 如果队尾为空，说明没有元素，则创建元素同时作为头尾节点
            {
                rear = new CharNode(Char, null);          //创建队头节点
                front = rear;
            }
            else    // 如果队尾不为空，说明有元素，则创建新节点并将其添加到队尾
            {
                rear.Next = new CharNode(Char, null);     //创建队尾节点
                rear = rear.Next;
            }
        }
        public char? Out()                               //出队
        {
            if (front == null) return null;
            char Char = front.Char;
            front = front.Next;
            if (front == null) rear = null;
            return Char;
        }
    }
    //字符链栈
    class CharStack
    {
        CharNode top;                                        //栈顶
        public void Push(char Char)                          //进栈
        {
            if (top == null) top = new CharNode(Char, null);  //创建栈顶节点
            else top = new CharNode(Char, top);
        }
        public char? Pop()                                   //出栈
        {
            if (this.top == null) return null;
            else
            {
                char Char = top.Char;
                top = top.Next;
                return Char;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();
            CharStack stack = new CharStack();                  //创建字符栈
            CharQueue queue = new CharQueue();
            foreach (var Char in str)
            {
                stack.Push(Char);                                //字符进栈
                queue.In(Char);                                  //字符进队
            }
            char? charStack, charQueue;
            // 字符串入栈入队后，栈从后往前出，队从前往后出，如果栈和队的字符全部相同，则是回文字符串
            do
            {
                charQueue = queue.Out();                         //字符出队
                charStack = stack.Pop();                         //字符出栈
                if (charStack != charQueue) break;
            } while (charStack != null && charQueue != null);
            if (charStack != null || charStack != null)
                Console.WriteLine("“{0}”不是回文", str);
            else
                Console.WriteLine("“{0}”是回文", str);
        }
    }
}
