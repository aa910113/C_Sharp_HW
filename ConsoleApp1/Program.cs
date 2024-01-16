using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// CH-5 Questin-1 -------------------------------------------------------------------------
            /// 利用一維陣列求10個數字的計算平均值。
            #region
            //int[] arrayA = new int[10];
            //int x = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    x += arrayA[j];
            //}
            //Console.WriteLine($"平均值為 : {x / 10}");
            //Console.Read();
            #endregion
            //// CH-5 Questin-2 -------------------------------------------------------------------------
            /// 利用一維陣列求10個數字的最大值。
            #region
            //int[] arrayA = new int[10];
            //int max = int.MinValue;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    if (arrayA[j] > max)
            //    {
            //        max = arrayA[j];
            //    }
            //}
            //Console.WriteLine($"最大值為 : {max}");
            //Console.Read();
            #endregion
            //// CH-5 Questin-3 -------------------------------------------------------------------------
            /// 搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在。
            #region
            //int[] searcharry = new int[10];
            //for (int i = 0; i < searcharry.Length; i++) {
            //    searcharry[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int x = Convert.ToInt32(Console.ReadLine());
            //for (int j = 0; j < searcharry.Length; j++) {
            //    if (searcharry[j] == x) {
            //        Console.WriteLine($"索引值為{j}");
            //        break;
            //    }
            //    if (j == searcharry.Length - 1) {
            //        Console.WriteLine("不存在");
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-4 -------------------------------------------------------------------------
            /// 兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。
            #region
            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[2, 3];
            //int[,] arrayC = new int[2, 3];

            //for (int i = 0; i < 2; i++) {
            //    for (int j = 0; j < 3; j++) {
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayC[i, j] += arrayA[i, j] + arrayB[i, j];
            //    }
            //}
            //foreach (int item in ArrayC) {
            //    Console.WriteLine(item);
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-5 -------------------------------------------------------------------------
            /// 兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來。
            #region
            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[3, 1];
            //int[,] arrayC = new int[2, 1];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 1; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        for (int z = 0; z < 3; z++)
            //        {
            //            arrayC[i, j] += arrayA[i, z] * arrayB[z, i];
            //        }
            //    }
            //}
            #endregion
            //// CH-5 Questin-6 -------------------------------------------------------------------------
            /// 寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5。
            #region
            //int[] arrayA = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    if (arrayA[j] > 5)
            //    {
            //        arrayA[j] -= 5;
            //    }
            //    else
            //    {
            //        arrayA[j] += 5;
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-7 -------------------------------------------------------------------------
            /// 寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i。
            #region
            //int[] arrayA = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    arrayA[j] += 1;
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-8 -------------------------------------------------------------------------
            /// 寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0。
            #region
            //int[] arrayA = new int[10];
            //int[] arrayB = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"請輸入第 {i + 1} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    if (arrayA[j] >= 0)
            //    {
            //        arrayB[j] = 1;
            //    }
            //    else
            //    {
            //        arrayB[j] = 0;
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-9 -------------------------------------------------------------------------
            /// 寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。
            #region
            //int[,] arrayA = new int[4, 6];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"請輸入第 {i + 1} 個陣列的第 {j + 1} 數 : ");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int x = 0; x < 3; x++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        arrayA[x, 5] += arrayA[x, y];
            //    }
            //}
            //for (int z = 0; z < 6; z++)
            //{
            //    for (int k = 0; k < 3; k++)
            //    {
            //        arrayA[3, z] += arrayA[k, z];
            //    }
            //}
            //for (int p = 0; p < 4; p++)
            //{
            //    for (int u = 0; u < 6; u++)
            //    {
            //        Console.Write($"{arrayA[p, u]} | ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-10 -------------------------------------------------------------------------
            /// 寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。
            #region
            //int[,] arrayA = new int[4, 6];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"請輸入第 {i + 1} 個陣列的第 {j + 1} 數 : ");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int x = 0; x < 3; x++)
            //{
            //    int min = int.MaxValue;
            //    min = arrayA[x, 0];
            //    for (int y = 0; y < 5; y++)
            //    {
            //        if (arrayA[x, y] < min)
            //        {
            //            min = arrayA[x, y];
            //        }
            //    }
            //    arrayA[x, 5] = min;
            //}
            //for (int z = 0; z < 6; z++)
            //{
            //    int min = int.MaxValue;
            //    min = arrayA[0, z];
            //    for (int k = 0; k < 3; k++)
            //    {
            //        if (arrayA[k, z] < min)
            //        {
            //            min = arrayA[k, z];
            //        }
            //    }
            //    arrayA[3, z] = min;
            //}
            //for (int p = 0; p < 4; p++)
            //{
            //    for (int u = 0; u < 6; u++)
            //    {
            //        Console.Write($"{arrayA[p, u]} | ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-11 -------------------------------------------------------------------------
            /// 寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。
            #region
            //int[] arrayA = new int[6];
            //int[] arrayB = new int[6];

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"請輸入 A 陣列的第 {i} 個數 : ");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 1; j <= 5; j++)
            //{
            //    Console.Write($"請輸入 B 陣列的第 {j} 個數 : ");
            //    arrayB[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int x = 1; x <= 5; x++)
            //{
            //    int c = arrayA[x] + arrayB[x];

            //    Console.WriteLine($"{arrayA[x]} + {arrayB[x]} = {c}");
            //}
            //Console.Read();
            #endregion
            //// CH-5 Questin-12 -------------------------------------------------------------------------
            /// 寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
            #region
            int[] arrayA = new int[5];
            int[] arrayB = new int[5];
            int max_a = int.MinValue;
            int max_b = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"請輸入 A 陣列的第 {i} 個數 : ");
                arrayA[i] = Convert.ToInt32(Console.ReadLine());
                if (arrayA[i] > max_a)
                {
                    max_a = arrayA[i];
                }
            }
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"請輸入 B 陣列的第 {j} 個數 : ");
                arrayB[j] = Convert.ToInt32(Console.ReadLine());
                if (arrayB[j] > max_b)
                {
                    max_b = arrayB[j];
                }
            }
            if (max_a < max_b)
            {
                Console.WriteLine($"A 為:{max_a}");
            }
            else
            {
                Console.WriteLine($"B 為:{max_b}");
            }
            Console.Read();
            #endregion
        }
    }
}