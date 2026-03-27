namespace _160_FileStatistics
{
    internal class Program
    {
        static int GetFileCount(string path)
        {
            int count = 0;                                         //文件数目
            DirectoryInfo directoryInfo = new DirectoryInfo(path); //路径信息
            count += directoryInfo.GetFiles().Length;              //获取路径下的文件数目
            foreach (var item in directoryInfo.GetDirectories())       //获取路径下的子目录
            {
                count += GetFileCount(item.FullName);         //获取子目录中的文件数目
            }
            return count;                                    //文件总数
        }
        static string GetSolutionRoot()
        {
            DirectoryInfo? dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null)
            {
                if (dir.GetFiles("*.sln").Length > 0)
                {
                    return dir.FullName;
                }
                dir = dir.Parent;
            }
            throw new DirectoryNotFoundException("Solution root not found.");
        }
        static void Main(string[] args)
        {
            string path = GetSolutionRoot();       //指定文件夹
            Console.WriteLine("路径{0}下的文件数目为：{1}", path, GetFileCount(path));
        }

    }
}
