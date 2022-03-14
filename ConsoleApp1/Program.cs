using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("請輸入數字");

            //string a = Console.ReadLine();
            //int b = int.Parse(a);
            //if (b % 2 == 1)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else if(b>=2 && b<=5)
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //else if (b >= 6 && b <= 20)
            //{
            //    Console.WriteLine("Weird");
            //}
            //else
            //{
            //    Console.WriteLine("Not Weird");
            //}
            //Console.ReadLine();


            //switch(b)
            //{
            //    case 2:
            //        Console.WriteLine("b = 2");
            //        break;
            //   default :
            //        Console.WriteLine("Default");
            //}
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("第" + i + "次迴圈");
            //    sun += i;
            //}
            //Console.WriteLine(sum);

            //int[] arr = { 1, 3, 5, 7 };


            //練習3 用兩個迴圈做出九九乘法表

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}x{j}={i * j}");
            //    }
            //}
            //Console.ReadKey();

            //練習1  星星
            //Console.WriteLine("請輸入數字：");
            //int rows = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= rows; i++)
            //{
            //    for (int k = 0; k <= 1 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            //Console.Read();

            //練習2
            //string a = Console.ReadLine();
            //int b = int.Parse(a);
            //for (var i = 1; i <= b; i++) 
            //{
            //    Console.WriteLine(b + "*" + i + "=" + (i * b));
            //}


            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = { "Jack", "Mark", "Mary", "Tom", "Alice" };
            int[] computerScore = { 80, 60, 90, 85, 62 };
            int[] progarmScore = { 48, 94, 52, 92, 84 };
            int[] animationScore = { 78, 86, 84, 94, 45 };

            while (true)
            {

                Console.WriteLine("請輸入座號(1-5)");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, inputStudentNo);
                if (arrayIndex > -1)
                {
                    Console.WriteLine("姓名:" + studentName[arrayIndex]);
                    Console.WriteLine("電腦概論:" + computerScore[arrayIndex]);
                    Console.WriteLine("程式設計:" + progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計:" + animationScore[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號!!!");
                }


            }

        }
    }
}


