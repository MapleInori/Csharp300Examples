namespace _159_GetDirectories
{
    internal class Program
    {
        static void DisplayDirectories(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);  //创建文件夹信息类实例
            Console.WriteLine(directoryInfo.FullName);           //输出文件夹信息
            foreach (DirectoryInfo DI in directoryInfo.GetDirectories())
            //遍历指定文件夹下所有的文件夹
            {
                DisplayDirectories(DI.FullName);                  //输出子文件夹信息
            }
        }
        static void Main(string[] args)
        {
            string path = GetSolutionRoot();  //项目根目录（包含 .sln 的目录）
            DisplayDirectories(path);                           //输出文件夹的所有子文件夹
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
    }
}
