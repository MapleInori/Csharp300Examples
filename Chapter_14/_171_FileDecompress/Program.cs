using System.IO.Compression;

namespace _171_FileDecompress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fileCompress = File.OpenRead("300 classic examples.gzip");//打开压缩文件
            Console.WriteLine("压缩文件大小为{0}字节", fileCompress.Length);  //输出压缩文件大小
            GZipStream compressionStream = new GZipStream(fileCompress,
        CompressionMode.Decompress);                    //创建压缩和解压缩流对象
            StreamReader reader = new StreamReader(compressionStream);  //流读取器
            string data = reader.ReadToEnd();                            //读取解压缩流中的
            Console.WriteLine("解压后的文件大小为{0}字节", data.Length);
            reader.Close();
            compressionStream.Close();
            Console.WriteLine(data);
            StreamWriter writer = File.CreateText("300 classic examples.txt");//创建原始文件
            writer.Write(data);                                 //将解压后的数据写入原始文件中
            writer.Close();
        }
    }
}
