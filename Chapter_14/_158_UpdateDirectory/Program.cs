using System.Security.AccessControl;

namespace _158_UpdateDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryName = "test";                      //文件夹名称
            if (!Directory.Exists(directoryName))               //判断文件夹是否存在
                Directory.CreateDirectory(directoryName);        //创建文件夹
                                                                 //获取文件夹访问控制列表
            DirectoryInfo dirInfo = new DirectoryInfo(directoryName);
            DirectorySecurity dirSecurity = dirInfo.GetAccessControl();
            //将指定访问控制列表添加到当前文件夹
            Console.WriteLine(Environment.UserName);
            dirSecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Read,
            InheritanceFlags.None, PropagationFlags.InheritOnly, AccessControlType.Allow));
            dirInfo.SetAccessControl(dirSecurity);
        }
    }
}
