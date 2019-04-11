using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_快速排序练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };

            QuickSort(data, 0, data.Length - 1);

            foreach (var item in data)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }


        static void QuickSort(int[] dataArray, int left, int right)
        {
            //if (left < right)
            //{
                int x = dataArray[left];
                int i = left;
                int j = right;

                while (i < j)
                {
                    while (true && i < j)
                    {
                        if (dataArray[j] <= x)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    while (true && i < j)
                    {
                        if (dataArray[i] > x)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    QuickSort(dataArray, left, i - 1);
                    QuickSort(dataArray, i + 1, right);
                }
            //}
        }
    }
}
