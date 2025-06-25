namespace _045_SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("《清明》");
            string[] poetry = new string[] { "清明时节雨纷纷，", "路上行人欲断魂。",
                                      "借问酒家何处有，", "牧童遥指杏花村。" };
            foreach (string sentence in poetry) Console.WriteLine(sentence);
            Console.Write("请输入需要提取的词语所在句子：");
            int line = int.Parse(Console.ReadLine()) - 1;
            Console.Write("请输入需要提取的词语起始位置：");   
            // 个人觉得这里应该是从需要截取的位置开始，而不是索引，从面向使用者来考虑，应该从1开始，
            // 而不应该当成索引来计算，不能默认使用者知道从0开始计数
            // 第几个字就是从几开始截取，而不应该是索引index
            int start = int.Parse(Console.ReadLine()) - 1;
            Console.Write("请输入需要提取的词语长度：");
            int length = int.Parse(Console.ReadLine());
            Console.Write(poetry[line].Substring(start, length));
        }
    }
}
