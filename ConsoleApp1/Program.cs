using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Globalization;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// CH-6 Questin-1 -------------------------------------------------------------------------
            //// 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
            #region
            //Console.WriteLine("輸入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hi~{name}");
            //Console.Read();
            #endregion
            //// CH-6 Questin-2 -------------------------------------------------------------------------
            //// 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
            #region
            //Console.WriteLine("輸入一個字");
            //char keyword = Convert.ToChar(Console.ReadLine());
            //string str = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //char[] array = str.ToCharArray();

            //foreach (char item in array)
            //{
            //    if (item == keyword)
            //    {
            //        Console.WriteLine($"{keyword} 出現在\"人人為我，我為人人、饒人不癡漢，癡漢不饒人\"裡");
            //        break;
            //    }
            //}
            //Console.WriteLine("沒有符合");
            //Console.Read();
            #endregion
            //// CH-6 Questin-3 -------------------------------------------------------------------------
            //// 輸入一段字，輸出每個之間多一個 -，如輸入apple ，輸出a - p - p - l - e。
            #region
            //Console.WriteLine("輸入一串字");
            //string x = Console.ReadLine();
            //char[] array = x.ToCharArray();
            //string y = "";

            //foreach (char item in array)
            //{
            //    y += $"{item}-";
            //}
            //y = y.Remove(y.Length - 1, 1);
            //Console.WriteLine(y);
            //Console.Read();
            //// CH-6 Questin-4 -------------------------------------------------------------------------
            //// 輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
            //Console.WriteLine("輸入一個檔案名稱");
            //string x = Console.ReadLine();
            //string[] y = x.Split('.');

            //Console.WriteLine($"副檔名為: {y[1]}");
            //Console.Read();
            #endregion
            //// CH-6 Questin-5 -------------------------------------------------------------------------
            //// 輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length Substring()
            #region
            //Console.WriteLine("輸入一個大於五個字的單字");
            //string x = Console.ReadLine();
            //if (x.Length > 5)
            //{
            //    Console.WriteLine(x.Substring(3));
            //}
            //else
            //{
            //    Console.WriteLine("長度不夠");
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-6 -------------------------------------------------------------------------
            //// 輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()
            #region
            //Console.WriteLine("輸入一段字");
            //string str = Console.ReadLine();
            //Console.WriteLine(str.Replace("我", "小明"));
            //Console.Read();
            #endregion
            //// CH-6 Questin-7 -------------------------------------------------------------------------
            //// 輸入一串字，顯示輸入幾個字。Length
            #region
            //Console.WriteLine("輸入一串字");
            //string str = Console.ReadLine();
            //Console.WriteLine($"這段字長度為:{str.Length}");
            //Console.Read();
            #endregion
            //// CH-6 Questin-8 -------------------------------------------------------------------------
            //// 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
            #region
            //string[] array = new string[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}組字");
            //    array[i] = Console.ReadLine();
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    bool x = array[j].Contains(" ");
            //    bool y = string.IsNullOrWhiteSpace(array[j]);
            //    if (x || y)
            //    {
            //        Console.WriteLine($"第 {j} 組沒出現過");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"第 {j} 組輸入過");
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-9 -------------------------------------------------------------------------
            //// 用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出 Fifa fIfa fiFa fifA
            #region
            //Console.WriteLine("輸入FiFa");
            //string str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    str = str.ToLower();
            //    char[] arr = str.ToCharArray();
            //    arr[i] = Convert.ToChar(arr[i].ToString().ToUpper());
            //    Console.WriteLine(arr);
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-10 -------------------------------------------------------------------------
            //// 輸入時間，顯示幾時幾分，例如輸入11: 30，輸出11點30分。
            #region
            //Console.WriteLine("請輸入一個時間，例如11: 30");
            //string str = Console.ReadLine();
            //Console.WriteLine($"{str.Replace(':', '時')}分");
            //Console.Read();
            #endregion
            //// CH-6 Questin-11 -------------------------------------------------------------------------
            //// 輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            ///<ul>
            /// <li>Justin</li>
            /// <li>Amy</li>
            /// <li>David</li>
            ///</ul>
            #region
            //Console.WriteLine("請輸入Justin,Amy,David");
            //string str = Console.ReadLine();
            //string[] arr = str.Split(',');
            //Console.WriteLine("<ul>");
            //foreach (string item in arr)
            //{
            //    Console.WriteLine($"  <li>{item}</li>");
            //}
            //Console.WriteLine("</ul>");
            //Console.Read();
            #endregion
            //// CH-6 Questin-12 -------------------------------------------------------------------------
            //// 輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
            #region
            //Console.WriteLine("輸入5處數字，用空白隔開");
            //string num = Console.ReadLine();
            //string[] arr = num.Split(' ');
            //int sum = 0;
            //foreach (string item in arr)
            //{
            //    sum += Convert.ToInt32(item);
            //}
            //Console.WriteLine(sum);
            //Console.Read();
            #endregion
            //// CH-6 Questin-13 -------------------------------------------------------------------------
            //// 輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
            #region
            //Console.WriteLine("輸入一串文字");
            //string str = Console.ReadLine();
            //Console.WriteLine(str.Reverse().ToArray());
            //Console.Read();
            #endregion
            //// CH-6 Questin-14 -------------------------------------------------------------------------
            //// 寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
            #region
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    sw.WriteLine("江湖一笑浪滔滔");
            //    sw.WriteLine("紅塵盡忘了");
            //    sw.WriteLine("俱往矣何足言道");
            //}
            #endregion
            //// CH-6 Questin-15 -------------------------------------------------------------------------
            //// 讀取 MyText.txt 顯示在畫面上。
            #region
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-16 -------------------------------------------------------------------------
            // 寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
            #region
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    for (int i = 1; i < 10; i++)
            //    {
            //        for (int j = 1;  j < 10;  j++)
            //        {
            //            sw.WriteLine($"{i} x {j} = {i*j}");
            //        }
            //    }
            //}
            #endregion
            //// CH-6 Questin-17 -------------------------------------------------------------------------
            // 讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF - 8)
            #region
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //string path2 = @"C:\Users\rnp91\Desktop\MyText2.txt";
            //StreamReader sr = new StreamReader(path);
            //StreamWriter sw = new StreamWriter(path2);
            //while (!sr.EndOfStream)
            //{
            //    string line = sr.ReadLine();
            //    line = line.Replace("0", "零");
            //    line = line.Replace("1", "壹").Replace("2", "貳").Replace("3", "參");
            //    line = line.Replace("4", "肆").Replace("5", "伍").Replace("6", "陸");
            //    line = line.Replace("7", "柒").Replace("8", "捌").Replace("9", "玖");
            //    sw.WriteLine(line);
            //}
            //sw.Close();
            //sr.Close();
            //Console.Read();
            #endregion
            //// CH-6 Questin-18 -------------------------------------------------------------------------
            // 讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            #region
            //// 請替換為您的CSV檔案路徑
            //string path = "path/to/your/fc4bb.csv";

            //// 讀取CSV檔案的所有行
            //string[] lines = File.ReadAllLines(path);

            //// 開始構建HTML表格
            //StringBuilder htmlTable = new StringBuilder();
            //htmlTable.AppendLine("<table border='1'>");

            //// 逐行處理CSV數據
            //foreach (string line in lines)
            //{
            //    // 使用逗號分隔符解析每一行的數據
            //    string[] values = line.Split(',');

            //    // 開始構建HTML表格的行
            //    htmlTable.AppendLine("<tr>");

            //    // 在這裡處理每個數據值，添加到HTML表格的單元格
            //    foreach (string value in values)
            //    {
            //        htmlTable.AppendLine($"<td>{value}</td>");
            //    }

            //    // 結束HTML表格的行
            //    htmlTable.AppendLine("</tr>");
            //}

            //// 結束HTML表格
            //htmlTable.AppendLine("</table>");

            //// 將HTML表格打印到控制台
            //Console.WriteLine(htmlTable.ToString());
            #endregion
            //// CH-6 Questin-19 -------------------------------------------------------------------------
            // 請隨機由0~99產生一個數字輸出。
            // Random rom = new Random();//亂數種子int I = rom.Next(0, 100);//回傳0-99的亂數
            #region
            //Random rom = new Random();
            //int i = rom.Next(0, 100);
            //Console.WriteLine($"亂數為 : {i}");
            //Console.Read();
            #endregion
            //// CH-6 Questin-20 -------------------------------------------------------------------------
            // 請隨機由0~99產生10個數字輸出。
            #region
            //List<int> arr = new List<int>();
            //Random rom = new Random();
            //while (arr.Count < 10)
            //{
            //    int i = rom.Next(0, 100);
            //    arr.Add(i);
            //}
            //for (int j = 0; j < arr.Count; j++)
            //{
            //    Console.WriteLine(arr[j]);
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-21 -------------------------------------------------------------------------
            // 隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
            #region
            //Console.Write("請輸入學生數 : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //Random rom = new Random();
            //using (StreamWriter sw = File.CreateText(path))
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        int x = rom.Next(0, 100);
            //        Console.WriteLine(x);
            //        sw.WriteLine($"{i} 號學生，{x} 分");
            //    }
            //}
            //Console.WriteLine("已完成");
            //Console.Read();
            #endregion
            //// CH-6 Questin-22 -------------------------------------------------------------------------
            // 請設計樂透開獎程式。
            #region
            //List<int> arr = new List<int>();
            //Random rom = new Random();
            //while (arr.Count < 6)
            //{
            //    int x = rom.Next(0, 49);
            //    // 確保生成的數字不重複
            //    if (!arr.Contains(x))
            //    {
            //        arr.Add(x);
            //    }
            //}
            //Console.WriteLine("開獎號碼");
            //foreach (int item in arr)
            //{
            //    Console.Write($",{item}");
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-23 -------------------------------------------------------------------------
            // 請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            #region
            // 假設文字檔的店家為 :麥當勞,肯德基,漢堡王
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //List<string> store = new List<string>();
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        string[] arr = s.Split(',');
            //        foreach (string item in arr)
            //        {
            //            store.Add(item);
            //        }
            //    }
            //}
            //Random rom = new Random();
            //int x = rom.Next(0, store.Count - 1);
            //Console.WriteLine($"今天中午吃 : {store[x]}");
            //Console.Read();
            #endregion
            //// CH-6 Questin-24 -------------------------------------------------------------------------
            // 請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            #region
            // 假設文字檔的學生為 : 麥當勞,肯德基,漢堡王,摩斯漢堡,丹丹漢堡
            //string path = @"C:\Users\rnp91\Desktop\MyText.txt";
            //List<string> students = new List<string>();
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        string[] arr = s.Split(',');
            //        foreach (string item in arr)
            //        {
            //            students.Add(item);
            //        }
            //    }
            //}
            //bool flag = true;
            //Random rom = new Random();
            //while (students.Count > 0)
            //{
            //    if (flag)
            //    {
            //        int x = rom.Next(0, students.Count - 1);
            //        Console.WriteLine($"今天日值日生 : {students[x]}");
            //        students.RemoveAt(x);
            //        flag = false;
            //        if (students.Count == 0)
            //        {
            //            Console.WriteLine("結束，已無值日生");
            //        }
            //        else
            //        {
            //            Console.WriteLine("是否要再抽一次 y/n");
            //            string str = Console.ReadLine();
            //            if (str == "y")
            //            {
            //                flag = true;
            //            }
            //            else
            //            {
            //                flag = false;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("結束");
            //        students.Clear();
            //    }
            //}
            //Console.Read();
            #endregion
            //// CH-6 Questin-25 -------------------------------------------------------------------------
            // 顯示現在日期與時間。
            #region
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"現在 : {now:西元yyyy年MM月dd日hh點mm分}");
            #endregion
            //// CH-6 Questin-26 -------------------------------------------------------------------------
            // 顯示再過30天為哪一天。
            #region
            //DateTime now = DateTime.Now;
            //DateTime af30 = now.AddDays(30);
            //Console.WriteLine($"再過30天為 : {af30:西元yyyy年MM月dd日}");
            #endregion
            //// CH-6 Questin-27 -------------------------------------------------------------------------
            // 顯示24小時前的年月日時分秒。
            #region
            //DateTime now = DateTime.Now;
            //DateTime bf24hr = now.AddHours(-24);
            //Console.WriteLine($"24小時前為 :  : {bf24hr:西元yyyy年MM月dd日hh點mm分}");
            #endregion
            //// CH-6 Questin-28 -------------------------------------------------------------------------
            // 取得目前是幾月
            #region
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"現在 : {now.Month}月");
            #endregion
            //// CH-6 Questin-29 -------------------------------------------------------------------------
            // 取得明年是否為閏年。(可以試試民國)
            #region
            //DateTime now = DateTime.Now;
            //now = now.AddYears(1);
            //if (now.Year % 4 == 0)
            //{
            //    if (now.Year % 100 == 0)
            //    {
            //        if (now.Year % 400 == 0)
            //        {
            //            Console.WriteLine($"明年{now.Year}年為閏年");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"明年{now.Year}年為平年");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"明年{now.Year}年為閏年");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"明年{now.Year}年為平年");
            //}
            #endregion
            //// CH-6 Questin-30 -------------------------------------------------------------------------
            // 取得離2025年1月1日還有幾天。
            #region
            //DateTime now = DateTime.Now;
            //DateTime ad = new DateTime(2025, 1, 1);
            //int days = (ad - now).Days;
            //Console.WriteLine($"離2025年1月1日還有{days}天");
            #endregion
            //// CH-6 Questin-31 -------------------------------------------------------------------------
            // 星期一，猴子穿新衣，
            // 星期二，猴子肚子餓，
            // 星期三，猴子去爬山，
            // 星期四，猴子看電視，
            // 呈期五，猴子去跳舞，
            // 星期六，猴子去斗六，
            // 星期日，猴子過生日。
            // 請顯示今天猴子做甚麼事。
            #region
            //DateTime now = DateTime.Now;
            //string dayOfWeek = Convert.ToString(now.DayOfWeek);
            //switch (dayOfWeek)
            //{
            //    case "Monday":
            //        Console.WriteLine("星期一，猴子穿新衣");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("星期二，猴子肚子餓");
            //        break;
            //    case "Wednesday":
            //        Console.WriteLine("星期三，猴子去爬山");
            //        break;
            //    case "Thursday":
            //        Console.WriteLine("星期四，猴子看電視");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("星期五，猴子去跳舞");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("星期六，猴子去斗六");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("星期日，猴子過生日");
            //        break;
            //    default:
            //        Console.WriteLine("無結果");
            //        break;
            //}
            // 切換中文----
            //DateTime now = DateTime.Now;
            //CultureInfo cultureInfo = new CultureInfo("zh-TW");
            //string chineseDayOfWeek = cultureInfo.DateTimeFormat.GetDayName(now.DayOfWeek);
            //Console.WriteLine(chineseDayOfWeek);
            #endregion
            //// CH-6 Questin-32 -------------------------------------------------------------------------
            // 輸入兩個日期，輸出兩個日期相差幾天。
            #region
            //Console.WriteLine("請輸入起始年");
            //int inpSY = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入起始月");
            //int inpSM = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入起始日");
            //int inpSD = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入結束年");
            //int inpEY = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入結束月");
            //int inpEM = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入結束日");
            //int inpED = Convert.ToInt32(Console.ReadLine());

            //DateTime sDate = new DateTime(inpSY, inpSM, inpSD);
            //DateTime eDate = new DateTime(inpEY, inpEM, inpED);

            //int days = (eDate - sDate).Days;
            //Console.WriteLine($"兩個日期相差{days}天");
            #endregion
            //// CH-6 Questin-33 -------------------------------------------------------------------------
            // 兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            // 他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            // M = 月 D = 日 S = (M * 2 + D) % 3
            // 得到 S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。
            #region
            //Random rom = new Random();
            //int M = rom.Next(1, 13);
            //int D = rom.Next(1, 31);
            //int S = (M * 2 + D) % 3;

            //if(S == 0)
            //{
            //    Console.WriteLine("普通");
            //}
            //else if (S == 1)
            //{
            //    Console.WriteLine("吉");
            //}
            //else if (S == 2)
            //{
            //    Console.WriteLine("大吉");
            //}
            #endregion
            //// CH-6 Questin-33 -------------------------------------------------------------------------
            //// 1. 寫一個function 可以把一般對話框的文字轉成HTML。> 轉成 &gt; < 轉成 &lt; \r\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp;
            //Console.WriteLine(fun("> 轉成 &gt; < 轉成 &lt; \r\n 轉成 <br> | 轉成 &brvbar; 空白 轉成 &nbsp;"));
            //Console.Read();
            //// CH-6 Questin-34 -------------------------------------------------------------------------
            //// 2. 寫一個function，回傳輸入的值是否數字
            //Console.Write("請輸入一個數字:");
            //string x = Console.ReadLine();
            //Console.WriteLine(fun(x));
            //Console.Read();
            //// CH-6 Questin-35 -------------------------------------------------------------------------
            //// 3. 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
            //Console.Write("請輸入E-mail地址: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(IsValidEmail(input));
            //Console.Read();
            //// CH-6 Questin-36 -------------------------------------------------------------------------
            //// 4. 寫一個function，回傳輸入的值是否符合手機格式
            //Console.Write("請輸入手機號碼: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(IsValidPhone(input));
            //Console.Read();
            //// CH-6 Questin-37 -------------------------------------------------------------------------
            //// 5. 寫一個function，回傳輸入的值是否符合身分證字號格式
            //Console.Write("請輸入身分證字號: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(IsValidID(input));
            //Console.Read();
            //// CH-6 Questin-38 -------------------------------------------------------------------------
            //// 6. 寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
            //Console.Write("請輸入文字長度: ");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入文字: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(FText(l, input));
            //Console.Read();
            //// CH-6 Questin-39 -------------------------------------------------------------------------
            //// 7. 寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
            //Console.WriteLine("請輸入西元年");
            //int inpSY = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入月");
            //int inpSM = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入日");
            //int inpSD = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(cgDate(inpSY, inpSM, inpSD));
            //Console.Read();
            //// CH-6 Questin-40 -------------------------------------------------------------------------
            //// 8. 寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式
            //Console.WriteLine("請輸入西元年");
            //int inpSY = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入月");
            //int inpSM = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入日");
            //int inpSD = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(cgDate(inpSY, inpSM, inpSD));
            //Console.Read();
            //// CH-6 Questin-41 -------------------------------------------------------------------------
            //// 9. 寫一個function，回傳輸入的年是否閏年
            //Console.WriteLine("請輸入西元年");
            //int Y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(fun(Y));
            //Console.Read();
            //// CH-6 Questin-42 -------------------------------------------------------------------------
            //// 10. 寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
            //Console.Write("請輸入手機號碼: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(fun(input));
            //Console.Read();
        }
        // Q-33
        #region
        //public static string fun(string p)
        //{
        //    return p.Replace(">", "&gt;").Replace("<", "&lt;").Replace("\r\n", "<br>").Replace("|", "&brvbar;").Replace(" ", "&nbsp;");
        //}
        #endregion
        // Q-34
        #region
        //public static string fun(string str)
        //{
        //    bool result = int.TryParse(str, out int n);
        //    string message;
        //    if (result)
        //    {
        //        message = "是數字";
        //    }
        //    else
        //    {
        //        message = "不是數字";
        //    }
        //    return message; 
        //}
        #endregion
        // Q-35
        #region
        //public static string IsValidEmail(string email)
        //{
        //    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        //    Regex regex = new Regex(pattern);
        //    string msg;
        //    if (regex.IsMatch(email))
        //    {
        //        msg = "是有效的E-mail地址。";
        //    }
        //    else
        //    {
        //        msg = "不是有效的E-mail地址。";
        //    }
        //    return msg;
        //}
        #endregion
        // Q-36
        #region
        //public static string IsValidPhone(string phoneNumber)
        //{
        //    string pattern = @"^09\d{8}$";
        //    Regex regex = new Regex(pattern);
        //    string msg;
        //    if (regex.IsMatch(phoneNumber))
        //    {
        //        msg = "是有效的手機號碼。";
        //    }
        //    else
        //    {
        //        msg = "不是有效的手機號碼。";
        //    }
        //    return msg;
        //}
        #endregion
        // Q-37
        #region
        //public static string IsValidID(string ID)
        //{
        //    string pattern = @"^[A-Z]{1}[1-2]{1}[0-9]{8}$";
        //    Regex regex = new Regex(pattern);
        //    string msg;
        //    if (regex.IsMatch(ID))
        //    {
        //        msg = "是有效的身分證字號。";
        //    }
        //    else
        //    {
        //        msg = "不是有效的身分證字號。";
        //    }
        //    return msg;
        //}
        #endregion
        // Q-38
        #region
        //public static string FText(int l , string p)
        //{
        //    p = p.Remove(l) + "...";
        //    return p;
        //}
        #endregion
        // Q-39
        #region
        //public static string cgDate(int Y, int M, int D)
        //{
        //    Y = Y - 1911;
        //    return $"民國{Y}年{M}月{D}日";
        //}
        #endregion
        // Q-40
        #region
        //public static string cgDate(int Y, int M, int D)
        //{
        //    DateTime date = new DateTime(Y, M, D);
        //    string dayOfWeek = Convert.ToString(date.DayOfWeek);
        //    string day = "";
        //    switch (dayOfWeek)
        //    {
        //        case "Monday":
        //            day = "星期一";
        //            break;
        //        case "Tuesday":
        //            day = "星期二";
        //            break;
        //        case "Wednesday":
        //            day = "星期三";
        //            break;
        //        case "Thursday":
        //            day = "星期四";
        //            break;
        //        case "Friday":
        //            day = "星期五";
        //            break;
        //        case "Saturday":
        //            day = "星期六";
        //            break;
        //        case "Sunday":
        //            day = "星期日";
        //            break;
        //        default:
        //            Console.WriteLine("無結果");
        //            break;
        //    }
        //    Y = Y - 1911;
        //    return $"民國{Y}年{M}月{D}日 {day}";
        //}
        #endregion
        // Q-41
        #region
        //public static string fun(int Y)
        //{
        //    string str;
        //    if (Y % 4 == 0)
        //    {
        //        if (Y % 100 == 0)
        //        {
        //            if (Y % 400 == 0)
        //            {
        //                str = "閏年";
        //            }
        //            else
        //            {
        //                str = "平年";
        //            }
        //        }
        //        else
        //        {
        //            str = "閏年";
        //        }
        //    }
        //    else
        //    {
        //        str = "平年";
        //    }
        //    return str;
        //}
        #endregion
        // Q-42
        #region
        //用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。
        //public static int fun(string phone)
        //{
        //    double lastFour = Convert.ToInt32(phone.Remove(0, 6));
        //    string[] substrings = Convert.ToString(lastFour / 80).Split('.');
        //    return Convert.ToInt32(substrings[1]) * 80;
        //}
        #endregion
    }
}