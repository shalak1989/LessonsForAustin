using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 7, 9, 11, 13, 15, 16, 17, 18, 19 };
            int[] b = { 2, 4, 6, 8, 10, 12, 14 };
            int[] final = ZipArrays(a, b);

            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] ZipArrays(int[] a, int[] b)
        {
            var zippedArray = new int[a.Length + b.Length];
            int aIndex = 0;
            int bIndex = 0;
            for (int i = 0; i < zippedArray.Length; i += 2)
            {
                if (i == 0)
                {
                    zippedArray[i] = a[aIndex];
                    zippedArray[i + 1] = b[bIndex];
                    aIndex++;
                    bIndex++;
                }
                else
                {
                    if (aIndex < a.Length && bIndex < b.Length)
                    {
                        zippedArray[i] = a[aIndex];
                        zippedArray[i + 1] = b[bIndex];
                        aIndex++;
                        bIndex++;
                    }
                    else if (aIndex < a.Length)
                    {
                        FinishZippingProcess(zippedArray, i, a, aIndex);
                        break;
                    }
                    else
                    {
                        FinishZippingProcess(zippedArray, i, b, bIndex);
                        break;
                    }
                }
            }

            return zippedArray;
        }

        public static void FinishZippingProcess(int[] targetArray, int targetIndex, int[] sourceArray, int sourceIndex)
        {
            for (int i = sourceIndex; i < sourceArray.Length; i++)
            {
                targetArray[targetIndex] = sourceArray[i];
                targetIndex++;
            }
        }

    }
}
