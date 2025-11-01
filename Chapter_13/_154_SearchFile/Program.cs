namespace _154_SearchFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Search(@"E:\VisualStudioProject\Csharp300Examples");  //搜索E:\VisualStudioProject\Csharp300Examples下的.sln后缀的文件
        }
        static void Search(object path)                         //搜索指定路径线程函数
        {
            DirectoryInfo DI = new DirectoryInfo(path.ToString());  //创建目录信息
            FileInfo[] FIs = DI.GetFiles("*.sln");               //获取.sln后缀的文件
            DirectoryInfo[] DIs = DI.GetDirectories();           //获取子目录
            foreach (var item in FIs) Console.WriteLine(item.FullName);//输出.sln后缀的文件
            foreach (var item in DIs)                            //创建线程，搜索子目录
            {
                Thread thread = new Thread(new ParameterizedThreadStart(Search));
                thread.Start(item.FullName);
            }
        }
    }
}
