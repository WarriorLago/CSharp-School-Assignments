using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21计科2_马菁含010069
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Directory.GetCurrentDirectory();
            }
            if (!Directory.Exists(path))
            {
                Console.WriteLine("路径不存在！");
                path = Directory.GetCurrentDirectory();
            }
            Console.WriteLine("当前目录：" + path);
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] files = di.GetFiles();
            Console.WriteLine("当前目录下的文件信息：");
            foreach (FileInfo file in files)
            {
                Console.WriteLine("{0} 创建时间：{1}，访问时间：{2}，修改时间：{3}", file.Name, file.CreationTime, file.LastAccessTime, file.LastWriteTime);
            }
            Console.ReadLine();
        }
    }
}
