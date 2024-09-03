using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21计科2班_马菁含069
{
    class Program
    {
        static void Main(string[] args)
        {
            string hanglie = Console.ReadLine();
            string[] hanglie1 = hanglie.Split(' ');
            string hang = hanglie1[0];
            string lie = hanglie1[1];
            int hang1 = int.Parse(hang);
            int lie1 = int.Parse(lie);
            int[,] arr1 = new int[hang1, lie1];
            int[,] arr2 = new int[hang1, lie1];


            for (int i = 0; i < hang1; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < lie1; j++)
                {
                    arr1[i, j] = int.Parse(line[j]);
                }
            }

            for (int i = 0; i < hang1; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < lie1; j++)
                {
                    arr2[i, j] = int.Parse(line[j]);
                }
            }


            string panduan1 = Console.ReadLine();
            double panduan = double.Parse(panduan1);
            int[,] result = new int[hang1, lie1];
            if (panduan == 1)
            {
                for (int i = 0; i < hang1; i++)
                {
                    for (int j = 0; j < lie1; j++)
                    {
                        result[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < hang1; i++)
                {
                    for (int j = 0; j < lie1; j++)
                    {
                        result[i, j] = arr1[i, j] - arr2[i, j];
                    }
                }
            }

            for (int i = 0; i < hang1; i++)
            {
                for (int j = 0; j < lie1; j++)
                {
                    Console.Write(result[i, j] + " ");
                }

                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
