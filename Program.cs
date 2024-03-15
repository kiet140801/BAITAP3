using System;
using System.Diagnostics.CodeAnalysis;

namespace BAITAP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai 1:
            /*
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 3 == 0)
            {
                Console.WriteLine($"{n} chia het cho 3");
            }
            else
            {
                Console.WriteLine($"{n} khong chia het cho 3");
            }
            */

            //Bai 2:
            /*
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Bang cuu chuong thu {i}", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, (i * j));
                }
                Console.WriteLine("Ket thuc bang cuu chuong");
            }
            */

            //bai 3:
            /*
            Console.WriteLine("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                a *= i;
            }
            Console.WriteLine($"Tong giai thua cua {n} la: {a}");
            */

            //bai 4:
            /*
            Console.Write("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(n);
            if (sqrt * sqrt == n)
            {
                Console.WriteLine($"{n} La so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} Khong phai la so chinh phuong");
            }
            */

            //bai 5:

            /*
            Console.Write("Nhap so thang: ");
            int month = int.Parse(Console.ReadLine());  

            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine($"Thang {month} co 31 ngay");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine($"Thang {month} co 30 ngay");
                    break;
                case 2:
                    Console.WriteLine($"Thang {month} co 28 hoac 29 ngay");
                    break;
                default:
                    Console.WriteLine("Thang khong hop le");
                    break;
            }
            */

            //bai 6:
            /*
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += (int)Math.Pow(i, i);
            }
            Console.WriteLine($"Tong ket qua la: {S}");
            */

            //bai 7:

            /*
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                Sum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Tong cac so la: {Sum}");
            */

            //bai 8:
            /*
            Console.Write("Nhap so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            
            if (n < 2 )
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
            for (int i = 2; i <= n; i++)
            {
                bool IsPrime = true;
                for (int j = 2  ; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    number++;
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine($"Tong cac so nguyen to tu 2 den {n} la: {number}");
            */

            //bai 9:
            
            //Console.Write("Nhap so hang: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //tam giac deu

            //int bien_dem;

            //bien_dem = n + 4 - 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = bien_dem; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
                
            //    Console.Write("* ");
            //    Console.Write("\n");
            //    bien_dem--;
            //}

            //tam giac xoay nguoc

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //bai 10:
            
            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) return;
            int a = 0, b = 1, c;
            Console.Write($"Day Fibonacci tu 1 den {n} la: ");
            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}
