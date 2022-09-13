using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_from_10._09._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 ");
            Console.WriteLine("2,7");
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3");
            Console.WriteLine("2\r\n6\r\n97\r\n92");
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите свое число");
            double x2 =  double.Parse(Console.ReadLine());
            Console.WriteLine(x2 + 10);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число равное стороне квадрата");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр квадрата со стороной указанной вами равен " + n * 4);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите длинну радиуса окружности");
            double r = double.Parse(Console.ReadLine());
            double l = 2 * 3.14 * r;
            double p = 3.14 * r * r;
            Console.WriteLine("Длина окружности равна " + l );
            Console.WriteLine("Площадь окружности равна " + p);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите градусную величену угла");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Косигус угла равен " + Math.Cos(x4));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите длинны сонований и высоты в очередности: основание1, основани2, высота ");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double x5 = Math.Max(d1 , d2) - Math.Min(d1, d2);
            Console.WriteLine("Периметр трапеции равен " + (2*Math.Sqrt((h * h) + (x5 * x5)) + d1 + d2));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Зфдание 9");
            Console.WriteLine("Введите массу купленных товаров. В очередности конфеты, печенье, яблоки \r\n Будем считать что стоимость товаров такова \r\n конфеты : 142 \r\n печенье : 87 \r\n nяблоки : 234");
            double z1 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double z3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Чек " + (z1 * 142) + (z2 * 87) + (z3 * 234));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            string k1 = "Мир";
            string k2 = "Труд";
            string k3 = "Май";
            Console.WriteLine("{0,0}\r\n{1, 10}\r\n{2, 15}", k1, k2, k3);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите два числа");
            var th1 = Console.ReadLine();
            var th2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Задание 12");
            Console.WriteLine("Что будем вычислять? Площадь или периметр?\r\n Для выбора площади введите 1 \r\n Для выбора периметра введите 2");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Какая фигура будет в центре нашего внимания?\r\n Для выбора треугольника введите 1\r\n Для выбора четырехугольника введите 2\r\n Для выбора круга введите 3");
            int ch1 = int.Parse(Console.ReadLine());
            if (ch1 == 1)
            {
                Console.WriteLine("Введите длинны стороны и высоты треугольника . По очереди");
                double x7 = double.Parse(Console.ReadLine());
                double x8 = double.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (x7 * x8 / 2) + "\r\n  Для четырехугольника площадь равна " + (x7 * x8) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(x7, x8) * Math.Max(x8, x7)));
                }
                if (ch == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((x7 * x7) + (x8 * x8)) + x7 + x8) + "\r\n Для четырехугольника периметр равен " + (2 * (x7 + x8)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(x7, x8) * 2 * 3.14));
                }
            }
            if (ch1 == 2)
            {
                Console.WriteLine("Введите длинны сторон высоты четырехугольника . По очереди");
                double x7 = double.Parse(Console.ReadLine());
                double x8 = double.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (x7 * x8 / 2) + "\r\n  Для четырехугольника площадь равна " + (x7 * x8) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(x7, x8) * Math.Max(x8, x7)));
                }
                if (ch == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((x7 * x7) + (x8 * x8)) + x7 + x8) + "\r\n Для четырехугольника периметр равен " + (2 * (x7 + x8)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(x7, x8) * 2 * 3.14));
                }
            }
            if (ch1 == 3)
            {
                Console.WriteLine("Введите длинну диаметра");
                double x7 = double.Parse(Console.ReadLine());
                double x8 = 0.5 * x7;
                if (ch == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (x7 * x8 / 2) + "\r\n  Для четырехугольника площадь равна " + (x7 * x8) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(x7, x8) * Math.Max(x8, x7)));
                }
                if (ch == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((x7 * x7) + (x8 * x8)) + x7 + x8) + "\r\n Для четырехугольника периметр равен " + (2 * (x7 + x8)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(x7, x8) * 2 * 3.14));
                }
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число");
            double x9 = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + x9);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг\r\n13 17");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 15");
            Random x = new Random();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(x.NextDouble());
            }
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите коэффиценты для квадратного уравнения ");
            Console.WriteLine("Введите значение коэффицента a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение коэффицента b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение коэффицента c ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Уравнение имеет вид " + a + "x^2 + (" + b + "x) + (" + c + ") = 0");
            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
                Console.WriteLine("Уравнение имеет корни:");
                Console.WriteLine("x1 = " + ((-b) + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("x2 = " + ((-b) - Math.Sqrt(d)) / (2 * a));
            }
            if (d < 0)
            {
                Console.WriteLine("Уравнение не имет корней");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 17");
            int x10 = 1021283;
            int x11 = 1937242;
            Console.WriteLine("известны два числа: " + x10,x11 + "\r\n Их среднее арифметическое равно " + ((x10 +x11) * 0.5 ) +"\r\n Их среднее геометрическое равно "+ (x11*x10*0.5));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 18");
            Console.WriteLine("Известны координаты точек A и В \r\nКоординаты точки А (2324;924)\r\nКоординаты точки В (752;223)");
            Console.WriteLine("Расстояние между точками равно " + Math.Sqrt(((2324 - 252) ^ 2) + ((924 - 223) ^ 2)));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 19\r\nЧасть a");
            int a11 = 15;
            int b11 = 99;
            int c11 = 2362;
            int d11 = b11;
            b11 = c11;
            c11 = a11;
            a11 = d11;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Часть б");
            a11 = 15;
            b11 = 99;
            c11 = 2362;
            d11 = b11;
            b11 = a11;
            a11 = c11;
            c11 = d11;
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите значение n");
            int n11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Прошло " + (n / 3600) + " часов " + ((n % 3600) / 60) + " минут " + (n / 60) + " секунд");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 21");
            Console.WriteLine("Из прямоугольника размером 130*543 можно вырежать " + 543 / 130 + " квадратов размером 130*130");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 22");
            int kk = 285;
            Console.WriteLine("Начальное число " + kk);
            string kk1 = Convert.ToString(kk % 10) + Convert.ToString(kk / 10);
            Console.WriteLine("Конечное число " + kk1);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 23");
            Console.WriteLine("Введите число n где n > 999");
            int x12 = int.Parse(Console.ReadLine());
            Console.WriteLine("В числе " + x12 + " Содержется " + (x12 / 100) + " сотен и " + (x12 / 1000) + " тысяч");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите четырехзначное число");
            int x13 = int.Parse(Console.ReadLine());
            string x14 = Convert.ToString(x13);
            if (x14.Length == 4)
            {
                Console.WriteLine("число, полученное при прочтении его цифр справа налево " + x14[4] + x14[3] + x14[2] + x14[1]);
                Console.WriteLine("число, образуемое при перестановке первой и второй, третьей и четвертой цифр " + x14[2] + x14[1] + x14[4] + x14[3]);
                Console.WriteLine("число, образуемое при перестановке второй и третьей цифр " + x14[1] + x14[3] + x14[2] + x14[4]);
                Console.WriteLine("число, образуемое при перестановке двух первых и двух последних цифр " + x14[3] + x14[4] + x14[1] + x14[2]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы ввели не четырехзначное число");
            }
            Console.Clear();

            Console.WriteLine("Задание 25");
            Console.WriteLine("Введите число n . n должго принадлежать отрезку [100;999] ");
            string x16 = Console.ReadLine();
            Console.WriteLine("Искомое число x = " + x16[2] + x16[0] + x16[1]);
            Console.ReadKey();

            Console.WriteLine("Задание 26");
            Console.WriteLine("Введите время. По очереди( часы, минуты, секунды,)");
            int h1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int s1 = int.Parse(Console.ReadLine());
            if (h1 > 11)
            {
                h1 -= 12;
            }
            double f = ((360 / 12) * h1 + (0.5 * m1) + (0.0083 * s1));
            Console.WriteLine("Сейчас угол между положением стрелки на начало дня и временем ввреденным вами равен " + f);
            Console.ReadKey();

            Console.WriteLine("Задание 28");
            Console.WriteLine("Введите три вещественных числа . По очереди ");
            List<double> chisl = new List<double>();
            int x19 = Math.Abs(int.Parse(Console.ReadLine()));
            int x20 = Math.Abs(int.Parse(Console.ReadLine()));
            int x21 = Math.Abs(int.Parse(Console.ReadLine()));
            chisl.AddRange(new double[]
                {
                    x19,
                    x20,
                    x21
                }
                           );
            Console.WriteLine(chisl.Max());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 29\r\nВведите три числа");
            chisl.Clear();
            chisl.Add(double.Parse(Console.ReadLine()));
            chisl.Add(double.Parse(Console.ReadLine()));
            chisl.Add(double.Parse(Console.ReadLine()));
            Console.WriteLine("Сумма большего и меньше из трех заданных чисел равна " + (chisl.Max() + chisl.Min()));
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 30\r\nВведите число ,у которого будет вычисляться количество делителей");
            int count = 2;
            int kk11 = int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(kk11); i++)
            {
                if (i == Math.Sqrt(kk11))
                {
                    count++;
                }
                if (kk11 % i == 0)
                {
                    count += 2;
                }
            }
            Console.WriteLine("У числа " + kk11 + ", " + count + " делителей(ля)");
            Console.ReadKey();
            Console.Clear();

            chisl.Clear();
            Console.WriteLine("Задание 31\r\nВедите коэфицинты уравнения третей степени");
            double x25 = double.Parse(Console.ReadLine());
            double x26 = double.Parse(Console.ReadLine());
            double x27 = double.Parse(Console.ReadLine());
            double x28 = double.Parse(Console.ReadLine());
            int ii = -100;
            do
            {
                if ((x25 * Math.Pow(ii, 3) + (x26 * Math.Pow(ii, 2)) + (x27 * ii) + x28) == 0)
                {
                    chisl.Add(ii);
                }
            }
            while (ii == 101);
            string str1 = "имеет " + Convert.ToString(chisl.Count) + " корней";
            string str2 = "не имет корней";
            string str3;
            if (chisl.Count > 0)
            {
                str3 = str1;
            }
            else
            {
                str3 = str2;
            }
            Console.WriteLine("Уравнение " + x25 + "x^3 + (" + x26 + "x^2) + (" + x27 + "x) + (" + x28 + ") " + str3 + " на участке [-100;100]");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
