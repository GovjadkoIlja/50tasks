// 50 Программ с сайта изучения Паскаля
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        public static void menu()
        {
            int n;
            Console.WriteLine("Все данные вводить через 'Enter'" + Environment.NewLine + "Для завершения программы нажмите 0" + Environment.NewLine + "Выберите номер задания, результат которого хотите вывести:");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    return;
                //break;
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                case 8:
                    task8();
                    break;
                case 9:
                    task9();
                    break;
                case 10:
                    task10();
                    break;
                case 11:
                    task11();
                    break;
                case 12:
                    task12();
                    break;
                case 13:
                    task13();
                    break;
                case 14:
                    task14();
                    break;
                case 15:
                    task15();
                    break;
                case 16:
                    task16();
                    break;
                case 17:
                    task17();
                    break;
                case 18:
                    task18();
                    break;
                case 19:
                    task19();
                    break;
                case 20:
                    task20();
                    break;
                case 21:
                    task21();
                    break;
                case 22:
                    task22();
                    break;
                case 23:
                    task23();
                    break;
                case 24:
                    task24();
                    break;
                case 25:
                    task25();
                    break;
                case 26:
                    task26();
                    break;
                case 27:
                    task27();
                    break;
                case 28:
                    task28();
                    break;
                case 29:
                    task29();
                    break;
                case 30:
                    task30();
                    break;
                case 31:
                    task31();
                    break;
                case 32:
                    task32();
                    break;
                case 33:
                    task33();
                    break;
                case 34:
                    task34();
                    break;
                case 35:
                    task35();
                    break;
                case 36:
                    task36();
                    break;
                case 37:
                    task37();
                    break;
                case 38:
                    task38();
                    break;
                case 39:
                    task39();
                    break;
                case 40:
                    task40();
                    break;
                case 41:
                    task41();
                    break;
                case 42:
                    task42();
                    break;
                case 43:
                    task43();
                    break;
                case 44:
                    task44();
                    break;
                case 45:
                    task45();
                    break;
                case 46:
                    task46();
                    break;
                case 47:
                    task47();
                    break;
                case 48:
                    task48();
                    break;
                case 49:
                    task49();
                    break;
                case 50:
                    task50();
                    break;

            }
            menu();
        }

        public static void task1()
        {
            Console.WriteLine("Hello World!");
        }

        public static void task2()
        {
            Console.WriteLine("Введите три числа:");
            int a;
            int b;
            int c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c + " " + b + " " + a);
        }

        public static void task3()
        {
            Console.WriteLine("Введите число:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * a);
        }

        public static void task4()
        {
            Console.WriteLine("Введите число:");
            int n;
            int[] mass = new int[3];
            int i;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 3; i++)
            {
                mass[i] = n % 10;
                n = n / 10;
            }
            for (i = 0; i < 3; i++)
            {
                Console.Write(mass[i]);
            }
            Console.WriteLine();
        }

        public static void task5()
        {
            Console.WriteLine("Введите число:");
            int n;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    s++;
                }
                n = n / 2;
            }
            Console.WriteLine(s);
        }

        public static void task6()
        {
            Console.WriteLine("Введите 2 числа");
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a > b ? a : b);
        }

        public static void task7()
        {
            int[] mass = new int[3];
            int i;
            Console.WriteLine("Введите 3 числа");
            for (i = 0; i < 3; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 2; i++)
                if (mass[i] > mass[i + 1])
                    mass[i + 1] = mass[i];
            Console.WriteLine(mass[2]);
        }

        public static void task8()
        {
            string[] mass = new string[7];
            mass[0] = "Понедельник";
            mass[1] = "Вторник";
            mass[2] = "Среда";
            mass[3] = "Четверг";
            mass[4] = "Пятница";
            mass[5] = "Суббота";
            mass[6] = "Воскресенье";
            Console.WriteLine("Введите номер дня недели");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mass[n - 1]);
        }

        public static void task9()
        {
            int n;
            string a;
            Console.WriteLine("Введите четырехзначное число");
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            Console.WriteLine((a[0] == a[3] && a[1] == a[2]) ? "ДА" : "НЕТ");
        }

        public static void task10()
        {
            int n;
            string a;
            Console.WriteLine("Введите четырехзначное число");
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            Console.WriteLine((a[0] + a[2] == a[1] + a[3]) ? "ДА" : "НЕТ");
        }

        public static void task11()
        {
            int n;
            int i;
            string a;
            bool q = true;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToString(n, 2);
            for (i = 0; i <= a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - 1 - i])
                    q = false;
            }
            Console.WriteLine(q == true ? "ДА" : "НЕТ");
        }

        public static void task12()
        {
            double a;
            double b;
            double c;
            double d;
            Console.WriteLine("Введите коэффициенты a, b и c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d < 0)
                Console.WriteLine("Нет корней");
            else
            {
                Console.WriteLine((-b + Math.Sqrt(d)) / 2 / a + " " + (-b - Math.Sqrt(d)) / 2 / a);
            }
        }

        public static void task13()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
                Console.Write(i + " ");
            Console.WriteLine();

        }

        public static void task14()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < Math.Sqrt(n) + 1; i++)
                if (n % i == 0)
                    s = i;
            if (s > 0)
                Console.WriteLine(s);
            else
                Console.WriteLine("Число простое");
        }

        public static void task15()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < Math.Sqrt(n) + 1; i++)
                if (n % i == 0)
                {
                    s = i;
                    break;
                }
            if (s > 0)
                Console.WriteLine(s);
            else
                Console.WriteLine("Число простое");
        }

        public static void task16()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n + 1; i++)
                if (n % i == 0)
                    s++;
            if (s > 0)
                Console.WriteLine(s);
            else
                Console.WriteLine("Число простое");
        }

        public static void task17()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            bool b = true;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < Math.Sqrt(n) + 1; i++)
                if (n % i == 0)
                {
                    b = false;
                    break;
                }
            Console.WriteLine((b == true) || (n == 2) ? "ДА" : "НЕТ");
        }

        public static void task18()
        {
            Console.WriteLine("Введите число");
            int i;
            int j;
            int n;
            bool b;
            n = Convert.ToInt32(Console.ReadLine());
            for (j = 2; j < n; j++)
            {
                b = true;
                for (i = 2; i < Math.Sqrt(j) + 1; i++)
                    if (j % i == 0)
                    {
                        b = false;
                        break;
                    }
                if ((b == true) || (j == 2)) Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        public static void task19()
        {
            Console.WriteLine("Введите число");
            int i;
            int j = 2;
            int n;
            int s = 0;
            bool b;
            n = Convert.ToInt32(Console.ReadLine());
            while (s < n)
            {
                b = true;
                for (i = 2; i < Math.Sqrt(j) + 1; i++)
                    if (j % i == 0)
                    {
                        b = false;
                        break;
                    }
                if ((b == true) || (j == 2))
                {
                    Console.Write(j + " ");
                    s++;
                }
                j++;
            }
            Console.WriteLine();

        }

        public static void task20()
        {
            Console.WriteLine("Введите число");
            int i;
            int n;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    s += i;
            }
            Console.WriteLine(s == n ? "ДА" : "НЕТ");
        }

        public static void task21()
        {
            Console.WriteLine("Введите два числа");
            int i;
            int n;
            int m;
            int sn = 0;
            int sm = 0;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sn += i;
            }
            for (i = 1; i < m; i++)
            {
                if (m % i == 0)
                    sm += i;
            }
            Console.WriteLine((sn == m) && (sm == n) ? "ДА" : "НЕТ");
        }

        public static void task22()
        {
            Console.WriteLine("Введите два числа");
            int i;
            int n;
            int m;
            int t;
            int s = 1;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            if (m > n)
                t = n;
            else
                t = m;
            for (i = 2; i <= t; i++)
            {
                if ((n % i == 0) && (m % i == 0))
                    s = i;
            }
            Console.WriteLine(s);
        }

        public static void task23()
        {
            Console.WriteLine("Введите два числа");
            int i;
            int n;
            int m;
            int t;
            int s = 1;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            if (m > n)
                t = m;
            else
                t = n;
            for (i = t; i <= t * t; i++)
            {
                if ((i % n == 0) && (i % m == 0))
                {
                    s = i;
                    break;
                }
            }
            Console.WriteLine(s);
        }

        public static void task24()
        {
            Console.WriteLine("Введите два числа");
            double x;
            double n;
            double s = 1;
            int i;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
                s *= x;
            Console.WriteLine(s);
        }

        public static void task25()
        {
            Console.WriteLine("Введите два числа");
            double x;
            double n;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            x = Math.Pow(x, n);
            Console.WriteLine(x);
        }

        public static void task26()
        {
            int n;
            double x1 = 0;
            double x2 = 0;
            int i;
            Console.WriteLine("Введите до какого числа рассматривать параметр");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                x1 = (Math.Sqrt(i * i + 3) - i);
                x2 = -(i + Math.Sqrt(i * i + 3));
                Console.Write(x1 + " " + x2);
                Console.WriteLine();
            }
        }

        public static void task27()
        {
            Console.WriteLine("Введите степень многочлена");
            int n;
            int i;
            double x;
            double s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            double[] mass = new double[n + 1];
            Console.WriteLine("Введите коэффициенты при слагаемых");
            for (i = n; i >= 0; i--)
                mass[i] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите точку значение в которой вы хотите найти");
            x = Convert.ToDouble(Console.ReadLine());
            for (i = 0; i <= n; i++)
                s += mass[i] * Math.Pow(x, i);
            Console.WriteLine(s);
        }

        public static void task28()
        {
            Console.WriteLine("Введите число");
            int n;
            int s = 1;
            n = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i <= n; i++)
                s = s * i;
            Console.WriteLine(s);
        }

        public static void task29()
        {
            Console.WriteLine("Введите n и k");
            int n;
            int k;
            int sn = 1;
            int sk = 1;
            int snk = 1;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i <= n; i++)
                sn = sn * i;
            for (i = 2; i <= k; i++)
                sk = sk * i;
            for (i = 2; i <= n - k; i++)
                snk = snk * i;
            Console.WriteLine(sn / sk / snk);
        }

        public static void task30()
        {
            Console.WriteLine("Введите число");
            int n;
            int i;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.Write(n + " " + n * n + " " + n * n * n);
                Console.WriteLine();
            }
        }

        public static void task31()
        {
            Console.WriteLine("Введите число");
            int n;
            string a;
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            char[] mass = a.ToCharArray();
            Array.Reverse(mass);
            Console.WriteLine(mass);
        }

        public static void task32()
        {
            Console.WriteLine("Введите число");
            int n;
            int i;
            int s = 0;
            bool b = true;
            string a;
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    if (s == -1)
                    {
                        b = false;
                        break;
                    }
                    s = 1;
                }
                if (a[i] < a[i + 1])
                {
                    if (s == 1)
                    {
                        b = false;
                        break;
                    }
                    s = -1;
                }
            }
            Console.WriteLine(b == true ? "ДА" : "НЕТ");
        }

        public static void task33()
        {
            Console.WriteLine("Введите число");
            int n;
            int i;
            bool b = false;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(n + "=");
            while (n > 1)
            {
                if (b == true)
                    Console.Write("*");
                b = true;
                for (i = 2; i <= n; i++)
                    if (n % i == 0)
                    {
                        n = n / i;
                        Console.Write(i);
                        break;
                    }
            }
            Console.WriteLine();
        }

        public static void task34()
        {
            Console.WriteLine("Введите два числа");
            int n;
            int m;
            int t;
            int i;
            string a;
            string b;
            string res = "";
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            t = (n > m ? n : m);
            a = n.ToString();
            b = m.ToString();
            char[] mass = a.ToCharArray();
            char[] arr = b.ToCharArray();
            for (i = 0; i < t; i++)
            {
                if (i < a.Length)
                    res = res + a[i];
                if (i < b.Length)
                    res = res + b[i];
            }
            Console.WriteLine(res);
        }

        public static void task35()
        {
            Console.WriteLine("Введите два числа");
            int x;
            int n;
            int t;
            int i;
            int k = 0;
            x = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            t = 1;
            while (t <= x)
            {
                t *= n;
                k++;
            }
            int[] mass = new int[k];
            for (i = k - 1; i > -1; i--)
            {
                mass[i] = x % n;
                x = x / n;
            }
            for (i = 0; i < k; i++)
                Console.Write(mass[i]);
            Console.WriteLine();
        }

        public static void task36()
        {
            Console.WriteLine("Введите два числа");
            int n;
            int m;
            int i;
            int s = 0;
            int min;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            min = (n > m ? m : n);
            for (i = 2; i < min; i++)
                if ((n % i == 0) && (m % i == 0))
                {
                    s = i;
                    break;
                }
            if (s == 0)
                Console.WriteLine("Нет делитетлей");
            else
                Console.WriteLine(s);

        }

        public static void task37()
        {
            Console.WriteLine("Введите число");
            int n;
            int s1 = 0;
            int s2 = 0;
            int i;
            string a;
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            char[] mass = a.ToCharArray();
            for (i = 0; i < mass.Length; i++)
            {
                if (i % 2 == 0)
                    s2 = s2 + (int)mass[i];
                else
                    s1 = s1 + (int)mass[i];
            }
            Console.WriteLine(s1 == s2 ? "ДА" : "НЕТ");
        }

        public static void task38()
        {
            Console.WriteLine("Введите число");
            int n;
            bool b = true;
            int i;
            string a;
            n = Convert.ToInt32(Console.ReadLine());
            a = n.ToString();
            char[] mass = a.ToCharArray();
            for (i = 0; i < a.Length / 2; i++)
                if (mass[i] != mass[a.Length - i - 1])
                    b = false;
            Console.WriteLine(b == true ? "ДА" : "НЕТ");
        }

        public static void task39()
        {
            Console.WriteLine("Введите число");
            int n;
            bool b = true;
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                if (n % 2 == 1)
                {
                    b = false;
                    break;
                }
                n /= 2;
            }
            Console.WriteLine(b == true ? "ДА" : "НЕТ");
        }

        public static void task40()
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            int s = 1;
            bool b = false;
            int i;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
                if (mass[i] % 2 == 0)
                {
                    s *= mass[i];
                    b = true;
                }
            Console.WriteLine(b == true ? s : 0);
        }

        public static void task41()
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            int s = 1;
            bool b = false;
            int i;
            int m;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число, на которое должны делиться элеметы последовательности");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
                if ((mass[i] > 9) && (mass[i] < 100) && mass[i] % m == 0)
                {
                    s *= mass[i];
                    b = true;
                }
            Console.WriteLine(b == true ? s : 0);
        }

        public static void task42()
        {

            Console.WriteLine("Введите количество чисел");
            int n;
            int s = 0;
            bool b = false;
            int i;
            int j;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                b = true;
                for (j = 2; j < Math.Sqrt(mass[i]); j++)
                    if (mass[i] % j == 0)
                    {
                        b = false;
                        break;
                    }
                if (b == true)
                    s++;
            }
            Console.WriteLine(s);
        }

        public static void task43()
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            bool b = false;
            int i;
            int l = -1;
            int t;
            int f = -1;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - число начинается с того, с того, которым заканчивается прошлое 0 - нет");
            for (i = 0; i < n; i++)
            {
                t = mass[i];
                while (t > 9)
                    t /= 10;
                f = t;
                if (f == l)
                    Console.Write(1);
                else if (b == true)
                    Console.Write(0);
                l = mass[i] % 10;
                b = true;
            }
            Console.WriteLine();
        }

        public static void task44()
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            bool b = true; ;
            int i;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n - 1; i++)
            {
                if (!(((mass[i - 1] > mass[i]) && (mass[i + 1] > mass[i])) || ((mass[i - 1] < mass[i]) && (mass[i + 1] < mass[i]))))
                {
                    b = false;
                    break;
                }
            }
            Console.WriteLine(b == true ? "ДА" : "НЕТ");
        }

        public static void task45()
        {
            Console.WriteLine("Введите количество чисел");
            int n;
            int b = 0;
            bool s = true;
            int i;
            int t;
            int f = -1;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите последовательность чисел");
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
                mass[i] = Convert.ToInt32(Console.ReadLine());
            if (mass[0] < mass[1])
                b = 1;
            if (mass[0] > mass[1])
                b = -1;
            for (i = 1; i < n - 1; i++)
            {
                if ((mass[i] < mass[i + 1]) && (b != 1))
                {
                    s = false;
                    break;
                }
                if ((mass[i] > mass[i + 1]) && (b != -1))
                {
                    s = false;
                    break;
                }
                if (mass[i] == mass[i + 1])
                {
                    s = false;
                    break;
                }
            }
            Console.WriteLine(s == true ? "ДА" : "НЕТ");
        }

        public static void task46()
        {
            int a = 1;
            int b = 1;
            int t;
            int n;
            int k = 2;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 3)
                Console.WriteLine(1);
            else
            {
                while (k < n)
                {
                    t = a + b;
                    a = b;
                    b = t;
                    k++;
                }
                Console.WriteLine(b);
            }
        }

        public static void task47()
        {
            int a = 1;
            int b = 1;
            int t;
            int n;
            int s = 2;
            int k = 2;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 3)
                Console.WriteLine(n);
            else
            {
                while (k < n)
                {
                    t = a + b;
                    a = b;
                    b = t;
                    s += t;
                    k++;
                }
                Console.WriteLine(s);
            }
        }

        public static void task48()
        {
            int a = 1;
            int b = 1;
            int t;
            int n;
            int s = 2;
            int k = 2;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(1);
            else if (n == 2)
                Console.WriteLine(1 + " " + 1);
            else if (n > 2)
            {
                for (int i = 0; i < 2; i++)
                    Console.Write(1 + " ");
                while (k < n)
                {
                    t = a + b;
                    a = b;
                    b = t;
                    s += t;
                    Console.Write(t + " ");
                    k++;
                }
            }
            Console.WriteLine();
        }

        public static void task49()
        {
            int i = 0;
            int s = 0;
            bool b = true;
            string a;
            Console.WriteLine("Введите строку");
            a = Console.ReadLine();
            char[] mass = a.ToCharArray();
            for (i = 0; i < a.Length; i++)
            {
                if (mass[i] == '(')
                    s++;
                if (mass[i] == ')')
                    s--;
                if (s < 0)
                {
                    b = false;
                    break;
                }
            }
            Console.WriteLine(((s == 0) && (b == true)) ? "ДА" : "НЕТ");
        }

        public static void task50()
        {
            double n;
            int q;
            double e;
            Console.WriteLine("Введите x и с точностью до какого знака после запятой хотите вычислить e^x");
            n = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            e = (Math.Pow(Math.E, n));
            Console.WriteLine(Math.Round(e, q));
        }

        public static double task50exp(int n)
        {
            int i;
            int t = n;
            int s = 1;
            for (i = 0; i < n; i++)
                t *= n;
            for (i = 2; i <= n; i++)
                s *= i;
            return (t / s);
        }

        static void Main(string[] args)
        {
            menu();
            //Console.ReadKey();
        }
    }
}
