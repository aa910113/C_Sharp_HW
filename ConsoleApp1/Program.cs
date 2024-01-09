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
            //// CH-3 Questin-1 -------------------------------------------------------------------------
            //// 讀入五個整數，求這五個整數的和。

            //int sum = 0;
            //int tmp;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine($"總和:{sum}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //int i = 0;
            //int sum = 0;
            //int tmp;
            //while (i < 5)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //    i++;
            //}
            //Console.WriteLine($"總和:{sum}");
            //Console.Read();


            //// CH-3 Questin-2 -------------------------------------------------------------------------
            //// 求 N 個整數的和，N 由使用者輸入。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine($"總和:{sum}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //int sum = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //    Console.WriteLine(sum);
            //    i++;
            //}
            //Console.WriteLine($"總和:{sum}");
            //Console.Read();

            //// CH-3 Questin-3 -------------------------------------------------------------------------
            //// 假設有 N 個正整數，求其中的最大值。
            //// 先假設最大值(MAX)等於 0，然後逐一檢查讀入的每一個數字，
            //// 如果比MAX還大，就令MAX等於這個數字，如果沒有比MAX大，
            //// 就不做任何事情，最後 MAX 一定會是這一串數字中的最大值。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > max)
            //    {
            //        max = tmp;
            //    }
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //int sum = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > max)
            //    {
            //        max = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();

            //// CH-3 Questin-4 -------------------------------------------------------------------------
            //// 假設有 N 個正整數，求最大奇數值。
            //// 用 % (取餘數)運算，例如將n除以 2 之後若餘 0，為偶數，若餘 1 則為奇數。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;
            //    }
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();


            //// CH-3 Questin-5 -------------------------------------------------------------------------
            //// 求 N 階層，即求 1×2×3×…× N。
            //// 請求輸入 N，讓 for 迴圈自 2 依序乘到 N，所以要寫成
            //// for(int i=2;i<N+1;i++)

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int val = 1;

            //for (int i = 2; i < n + 1; i++)
            //{
            //    val *= i;
            //}
            //Console.WriteLine($"val 為:{val}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int val = 1;
            //int i = 2;

            //while (i < n + 1)
            //{
            //    val *= i;
            //    i++;
            //}
            //Console.WriteLine($"val 為:{val}");
            //Console.Read();

            //// CH-3 Questin-6 -------------------------------------------------------------------------
            //// 輸出一個九九乘法表。

            //Console.WriteLine($"開始輸出99乘法表：");
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int x = 1; x < 10; x++)
            //    {
            //        Console.WriteLine($"{i} x {x} = {i * x}");
            //    }
            //}
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.WriteLine($"開始輸出99乘法表：");
            //int i = 1;
            //while (i < 10)
            //{
            //    int x = 1;
            //    while (x < 10)
            //    {
            //        Console.WriteLine($"{i} x {x} = {i * x}");
            //        x++;
            //    }
            //    i++;
            //}
            //Console.Read();

            // CH-3 Questin-7 -------------------------------------------------------------------------
            // 將九九乘法表改成 3x3 的格式。

            //Console.WriteLine($"開始輸出99乘法表：");
            //int q = 0;
            //for (int i = 1; i < 4; i++)
            //{
            //    for (int x = 1; x < 10; x++)
            //    {
            //        for (int z = 1; z < 4; z++)
            //        {
            //            Console.Write($"{z + q} x {x}  = {(z + q) * x}          ");
            //        }
            //        Console.WriteLine("");
            //    }
            //    q += 3;
            //    Console.WriteLine("");
            //}
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.WriteLine($"開始輸出99乘法表：");
            //int q = 0;
            //int i = 1;
            //while (i < 4)
            //{
            //    int x = 1;
            //    while ( x < 10)
            //    {
            //        int z = 1;
            //        while ( z < 4)
            //        {
            //            Console.Write($"{z + q} x {x}  = {(z + q) * x}          ");
            //            z++;
            //        }
            //        Console.WriteLine("");
            //        x++;
            //    }
            //    q += 3;
            //    Console.WriteLine("");
            //    i++;
            //}
            //Console.Read();

            // CH-3 Questin-8 -------------------------------------------------------------------------
            // 寫一程式，輸入10個整數，求其最小值。
            //int min = int.MaxValue;
            //int tmp = 0;
            //for (int i = 2; i < 11; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //}
            //Console.WriteLine($"Min 為:{min}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //int min = int.MaxValue;
            //int tmp = 0;
            //int i = 2;
            //while (i < 11)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Min 為:{min}");
            //Console.Read();

            // CH-3 Questin-8 -------------------------------------------------------------------------
            // 寫一程式，輸入N個整數，求其最小值。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int min = int.MaxValue;
            //int tmp = 0;
            //for (int i = 2; i < n + 1; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //}
            //Console.WriteLine($"Min 為:{min}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int min = int.MaxValue;
            //int tmp = 0;
            //int i = 2;
            //while (i < n + 1)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < min)
            //    {
            //        min = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Min 為:{min}");
            //Console.Read();

            // CH-3 Questin-9 -------------------------------------------------------------------------
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字。

            //string OUT = "";
            //int tmp = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 12) {
            //        OUT = $"{OUT + tmp}、";
            //    }
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //string OUT = "";
            //int tmp = 0;
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 12)
            //    {
            //        OUT = $"{OUT + tmp}、";
            //    }
            //    i++;
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            // CH-3 Questin-10 -------------------------------------------------------------------------
            // 寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。

            //string OUT = "";
            //int sum = 0;
            //int tmp = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 12)
            //    {
            //        OUT = $"{OUT + tmp}、";
            //        sum += tmp;
            //    }
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.WriteLine($"總和為:{sum}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //string OUT = "";
            //int sum = 0;
            //int tmp = 0;
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 12)
            //    {
            //        OUT = $"{OUT + tmp}、";
            //        sum += tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.WriteLine($"總和為:{sum}");
            //Console.Read();

            // CH-3 Questin-11 -------------------------------------------------------------------------
            // 寫一程式，輸入N個數字，求其所有奇數中的最大值。
            // 例如輸入11,12,3,24,15，答案是15。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;
            //    }
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp % 2 != 0 && tmp > max)
            //    {
            //        max = tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"Max 為:{max}");
            //Console.Read();

            // CH-3 Questin-12 -------------------------------------------------------------------------
            // 寫一程式，輸入N個數字，求其所有正數之平方的加總。
            // 例如輸入1,-2,3,-4,5五個數字，得到
            // 12 + (-2)2 + 32 + (-4)2 + 52 = 1 + 9 + 25 = 35

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 0)
            //    {
            //        sum += tmp * tmp;
            //    }
            //}
            //Console.WriteLine($"總和為:{sum}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //int sum = 0;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp > 0)
            //    {
            //        sum += tmp * tmp;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"總和為:{sum}");
            //Console.Read();

            // CH-3 Questin-12 -------------------------------------------------------------------------
            // 寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，
            // 例如-7會被轉換成7。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //string OUT = "";
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < 0)
            //    {
            //        tmp *= -1;
            //    }
            //    OUT += $"{tmp}、";
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = 0;
            //string OUT = "";
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp < 0)
            //    {
            //        tmp *= -1;
            //    }
            //    OUT += $"{tmp}、";
            //    i++;
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            // CH-3 Questin-13 -------------------------------------------------------------------------
            // 判斷101-200之間有多少個質數，並輸出所有質數。

            //string OUT = "";
            //for (int i = 101; i < 201; i++) {
            //    if ((i % 2 != 0) && (i % 3 != 0)) {
            //        OUT = $"{OUT + i}、";
            //    }
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //string OUT = "";
            //int i = 101;
            //while (i < 201)
            //{
            //    if ((i % 2 != 0) && (i % 3 != 0))
            //    {
            //        OUT = $"{OUT + i}、";
            //    }
            //    i++;
            //}
            //Console.WriteLine($"OUT 為:{OUT}");
            //Console.Read();

            // CH-3 Questin-13 -------------------------------------------------------------------------
            // 輸入一個數，輸出其質因數

            //Console.Write("輸入一個正整數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = n;
            //string OUT = "";
            //for (int i = 2; i < n; i++)
            //{
            //    if (tmp % i == 0) {
            //        tmp = tmp / i;
            //        OUT = $"{OUT + i} 、";
            //        i--;
            //    }
            //}
            //Console.WriteLine($"{n} 的質因數有:{OUT}");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //Console.Write("輸入一個正整數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int tmp = n;
            //string OUT = "";
            //int i = 2;
            //while (i < n)
            //{
            //    if (tmp % i == 0)
            //    {
            //        tmp = tmp / i;
            //        OUT = $"{OUT + i} 、";
            //        i--;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n} 的質因數有:{OUT}");
            //Console.Read();

            // CH-3 Questin-14 -------------------------------------------------------------------------
            // 求100到300中可以被3與7整除的個數。

            //int count = 0;
            //for (int i = 100; i < 301; i++)
            //{
            //    if ((i % 3 == 0) && (i % 3 == 0)) {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine($"總共有: {count} 個");
            //Console.Read();

            //// ------------改為 while 寫法---------------

            //int count = 0;
            //int i = 100;
            //while (i < 301)
            //{
            //    if ((i % 3 == 0) && (i % 3 == 0))
            //    {
            //        count += 1;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"總共有: {count} 個");
            //Console.Read();


            // ----------------------------------------------------------------------------------------
            // ----------------------------------------------------------------------------------------
            // CH-4 Questin-1 -------------------------------------------------------------------------

            // 讀入一連串的數字，但事先不知道數字的數目。
            // 設定一個特殊的數字，一旦讀到這個數字就終止迴圈。
            // 假設輸入的都是正數，一旦讀到負數就終止。

            //int x = 0;
            //while (x >= 0) {
            //    Console.WriteLine($"目前數值為:{x}");
            //    Console.Write("請輸入數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Read();

            // CH-4 Questin-2 -------------------------------------------------------------------------
            // 輸入2個數，求最大公約數

            //Console.Write("請輸入第一個整數:");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸入第二個整數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int x = m;
            //int y = n;

            //while (x != y) {
            //    if (x > y)
            //    {
            //        x = x - y;
            //    }
            //    else {
            //        y = y - x;
            //    }
            //}
            //Console.WriteLine($"最大公約數為:{x}");
            //Console.Read();

            // CH-4 Questin-3 -------------------------------------------------------------------------
            // 計算N個數字的和。
            // 檢查i有沒有超過N，超過就不做了。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //int s = 0;
            //while (i <= n)
            //{
            //    int x = 0;
            //    Console.Write("請輸入一個數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    s += x;
            //    i++;
            //}
            //Console.WriteLine($"數字為:{s}");
            //Console.Read();

            // CH-4 Questin-4 -------------------------------------------------------------------------
            // 利用while寫一程式求N個數字的最大值。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int x = 0;
            //int i = 1;
            //while (i <= n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x > max)
            //    {
            //        max = x;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"最大值為為:{max}");
            //Console.Read();

            // CH-4 Questin-5 -------------------------------------------------------------------------
            // 利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
            // (即從起始值開始，間格差，共N個 的總和)

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸起始值:");
            //int s = Convert.ToInt32(Console.ReadLine());
            //Console.Write("請輸數字間的差:");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while (n > 0)
            //{
            //    sum += s;
            //    s += i;
            //    n -= 1;
            //}
            //Console.WriteLine($"數字總和為:{sum}");
            //Console.Read();

            // CH-4 Questin-6 -------------------------------------------------------------------------
            // 利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //int s = 0;
            //while (i <= n)
            //{
            //    int x = 0;
            //    Console.Write("請輸入一個數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x < 13)
            //    {
            //        s += x;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"數字為:{s}");
            //Console.Read();

            // CH-4 Questin-7 -------------------------------------------------------------------------
            // 利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字。

            //Console.Write("請輸入迴圈次數:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int i = 1;
            //int x = 0;
            //while (i <= n)
            //{
            //    Console.Write("請輸入一個數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (x > 7 && x < 10)
            //    {
            //        Console.WriteLine($"數字為:{x}");
            //        n = 0;
            //    }
            //    i++;
            //}
            //Console.Read();

            // CH-4 Questin-8 -------------------------------------------------------------------------
            // 利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。

            //int[] a = new int[5];
            //Console.WriteLine("請輸入a1, a2, ..., a5：");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"請輸入 a{i + 1}: ");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int[] b = new int[5];
            //Console.WriteLine("請輸入b1, b2, ..., b5：");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"請輸入 b{i + 1}: ");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int x = 0;
            //while (x < 5)
            //{
            //    if (a[x] > b[x])
            //    {
            //        Console.WriteLine($"a{x + 1}為: {a[x]}, b{x + 1}: {b[x]}");
            //        break;
            //    }
            //    x++;
            //}
            //Console.Read();

            // CH-4 Questin-9 -------------------------------------------------------------------------
            //Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。

            //Console.Write("請輸入 Eric 吃漢堡的時間(將會乘以 5 分鐘):");
            //int t = Convert.ToInt32(Console.ReadLine()) * 5;
            //int i = 0;
            //int b = 0;
            //while (i < t)
            //{
            //    if (i % 5 == 0)
            //    {
            //        b += 1;
            //        Console.WriteLine($"第 {b} 個漢堡");
            //    }
            //    i++;
            //}
            //Console.Read();

            // CH-4 Questin-10 -------------------------------------------------------------------------
            // 小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。

            //int i = 0;
            //int m = 0;
            //while (i < 560)
            //{
            //    i += 4;
            //    m += 1;
            //    if (m % 12 == 0)
            //    {
            //        i += 1;
            //    }
            //    Console.WriteLine($"第{m}個月，還款累計{i}");
            //}
            //Console.Read();

            // CH-4 Questin-11 -------------------------------------------------------------------------
            // 系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。

            //Random random = new Random();
            //int randomNumber = random.Next(1, 101);
            //Console.WriteLine("系統已產生一個 1 - 100 的隨機數字。");
            //int x = 0;
            //while (x != randomNumber)
            //{
            //    Console.Write("請輸入一個數字:");
            //    x = Convert.ToInt32(Console.ReadLine());
            //    if (randomNumber > x) {
            //        Console.WriteLine("數字比系統小。");
            //    } else if(randomNumber < x)
            //    {
            //        Console.WriteLine("數字比系統大。");
            //    }
            //}
            //Console.WriteLine("已猜中系統數字。");
            //Console.Read();
        }
    }
}