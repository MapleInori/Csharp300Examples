using System.IO;

namespace Common;

public static class PathHelper
{
    public static string GetSolutionRoot()
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

    public static string GetDataDirectory()
    {
        return Path.Combine(GetSolutionRoot(), "data");
    }

    public static void EnsureDataDirectory()
    {
        Directory.CreateDirectory(GetDataDirectory());
    }

    public static void SetCurrentDirectoryToSolutionRoot()
    {
        Directory.SetCurrentDirectory(GetSolutionRoot());
    }
}
