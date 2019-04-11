using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            SelectSort(data);
            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        static void SelectSort(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                int min = dataArray[i];
                int minIndex = i;//最小值所在索引

                //这一层循环是将i位置的数与后面的数进行比较，拿到最小值，如果有最小值则将所在Index标记出来。
                for (int j = i + 1; j < dataArray.Length - 1; j++)
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }

                //将当前遍历的i位置的数与最小值进行数值上的交换。
                if (minIndex != i)
                {
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }

    }

}
