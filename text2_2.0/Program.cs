using System;

namespace text2_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] TextDate = { 2, 4, 5, 6, 7, 8, 9, 10 };
            All(TextDate);
        }
        static void Max(int[] a)//求最大值
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)//比較
                if (max < a[i])
                    max = a[i];
            Console.WriteLine("數組的最大值是{0}", max);
        }
        static void Min(int[] a)//求最小值
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)//比較
                if (min > a[i])
                    min = a[i];
            Console.WriteLine("數組的最小值是{0}", min);
        }

        static void Average(int[] a)//求均值
        {
            double sum = 0.0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            double average = sum / a.Length;
            Console.WriteLine("數組的平均值是{0}", average);
        }
        static void Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            Console.WriteLine("數組的總和是{0}", sum);
        }
        static void All(int[] a)
        {
            Max(a);
            Min(a);
            Average(a);
            Sum(a);
        }
    }
}
