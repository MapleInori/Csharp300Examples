namespace _027_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 12;

            for (int i = 1; i <= height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");                  //输出空格
                }
                // 从第二行开始，每行少的空格由这里补上，少的空格的位置被替换成*，再补上缺少的空格
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");                 //输出*和空格，如果没有空格，会变成直角三角形，空格将三角形右边部分补齐
                }
                // 如果是**的话，看起来好像行，但是会导致最顶部是两个**，而如果是*和空格，空格并不可见，所以顶部还是一个
                // 主要逻辑感觉说不太清楚，还是我不太明白，可以用注意力大法，注意到！
                Console.WriteLine();                    //换行
            }
        }
    }
}
