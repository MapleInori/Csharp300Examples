using System.Security.Cryptography.X509Certificates;

namespace _041_BracketChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入带括号的表达式：");
            string expression = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();
            bool isValid = true;  // 是否有效的标志
            foreach (char bracket in expression)
            {
                if(bracket != '(' && bracket != ')' && bracket != '[' && bracket != ']' && bracket != '{' && bracket != '}')
                {
                    continue;   // 如果不是括号，则跳过
                }

                // 左括号入栈
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    brackets.Push(bracket);    //括号进入栈
                }
                else if((bracket == ')' || bracket == ']' || bracket == '}') && brackets.Count == 0)    // 栈内没有元素，说明右括号没有匹配的左括号
                {
                    Console.WriteLine("表达式括号格式错误！1，当前右括号无匹配的左括号。");
                    isValid = false;  // 设置标志为无效
                    break;
                }
                else if ( (bracket == ')' && brackets.Peek() == '(')
                       || (bracket == ']' && brackets.Peek() == '[')
                       || (bracket == '}' && brackets.Peek() == '{') )    // 匹配正确
                {
                    brackets.Pop();
                }
                else        // 匹配错误
                {
                    Console.WriteLine("表达式括号格式错误！2，当前左右括号匹配错误。");
                    isValid = false;
                    break;  // 错误后直接break跳出，如果是continue，则依然会出栈所有元素，导致最后栈内元素为0，打印最后的“表达式括号格式正确！”
                }
            }
            // 如果最后一个错误，在执行判断时也将栈顶元素出栈了，所以需要修改判断逻辑,Pop该为Peek，判断而不出栈
            if(isValid && brackets.Count == 0)
            {
                Console.WriteLine("表达式括号格式正确！");
            }
            else if(isValid && brackets.Count >0)
            {
                Console.WriteLine("表达式括号格式错误！3，有多余的左括号没有进行匹配");
            }
        }
    }
}
