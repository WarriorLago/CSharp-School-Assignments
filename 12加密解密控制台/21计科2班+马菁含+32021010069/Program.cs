using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21计科2班_马菁含_32021010069
{
    class Program
    {
        static void jiami(string path, string output, int key)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    while (!reader.EndOfStream)
                    {
                        char c = (char)reader.Read();
                        int after = c + key;
                        char after1 = (char)after;
                        writer.Write(after1);
                    }
                }
            }
        }

        static void jiemi(string path, string output, int key)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    while (!reader.EndOfStream)
                    {
                        char c = (char)reader.Read();
                        int after2 = c - key;
                        char afterall = (char)after2;
                        writer.Write(afterall);
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            string jiamipath = "加密后的.txt";
            string jiemipath = "解密后的.txt";


            Console.Write("请输入要加密的文件目录（例如./input.txt）：");
            string path = Console.ReadLine();

            // 加密文件
            Console.Write("请输入加密密钥：");
            int key = int.Parse(Console.ReadLine());
            jiami(path, jiamipath, key);
            Console.WriteLine("已经加密成功，在路径: ./加密后的.txt");

            // 解密文件
            Console.Write("现在开始解密\n请输入解密密钥：");
            int afterkey = -(int.Parse(Console.ReadLine()));
            jiemi(jiamipath, jiemipath, afterkey);
            Console.WriteLine("已经解密成功，在路径: ./解密后的.txt");
            Console.ReadLine();
        }


    }
}
