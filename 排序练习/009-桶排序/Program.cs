using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_桶排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }


            for (int i = 0; i < data.Length; i++)
            {
                a[data[i]]++;
            }


            //打印输出的时候，循环桶的编号，
            for (int i = 0; i < a.Length; i++)
            {
                //判断桶内是否有数字？有几个数字？输出打印。
                for (int j = 1; j <= a[i]; j++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();


        }
    }
}
