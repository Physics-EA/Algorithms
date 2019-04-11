using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_插入排序
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] data = new int[] { 42, 20, 17, 27, 13, 8, 17, 48 };
            InsertSort(data);
            foreach (var temp in data)
            {
                Console.Write(temp + " ");
            }
            Console.ReadKey();
        }

        static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int iValue = dataArray[i];
                bool isInsert = false;

                //拿到i位置的元素iValue,从右向左跟前面所有的元素做比较,如果比iValue大，就将这个数向后移动一位。
                for (int j = i - 1; j >= 0; j--)//为什么要j >= 0？因为dataArray[0]号元素也需要比较，如果只j > 0，则iValue无法与dataArray[0]号元素比较。
                {
                    if (iValue < dataArray[j])
                    {
                        dataArray[j + 1] = dataArray[j];
                    }

                    else if (iValue >= dataArray[j])
                    {
                        dataArray[j + 1] = iValue;
                        isInsert = true;
                        break;
                    }
                }

                if (isInsert == false)
                {
                    dataArray[0] = iValue;
                }
            }
        }

    }
}
