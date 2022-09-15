using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_from_10._09._2022
{
    class Program
    {
        static double side(double footing1, double footing2, double height)
        {
            int possibility;
            if (footing1 < 0 || footing2 < 0 || height < 0)
            {
                possibility = 1;
            }
            else
            {
                possibility = 0;
            }
            return possibility;
        }
        static void Main(string[] args)
        {
            string transition = "Для продолжения нажмите на Enter";
            Console.WriteLine("Задание 1 ");
            Console.WriteLine(Math.Round(Math.E, 1));
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 3");
            Console.WriteLine("2\r\n6\r\n97\r\n92");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите свое число");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine(x2 + 10);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите положительно число равное стороне квадрата");
            double sidesquare = double.Parse(Console.ReadLine());
            if (sidesquare > 0)
            {
                Console.WriteLine("Периметр квадрата со стороной указанной вами равен " + sidesquare * 4);
            }
            else
            {
                Console.WriteLine("Число должно быть положительным. Теперь запускайте все завново!!!");
            }
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите длинну радиуса окружности");
            double r = double.Parse(Console.ReadLine());
            double l = 2 * 3.14 * r;
            double p = 3.14 * r * r;
            Console.WriteLine("Длина окружности равна " + l);
            Console.WriteLine("Площадь окружности равна " + p);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите градусную величену угла");
            double corner = double.Parse(Console.ReadLine());
            Console.WriteLine("Косинус угла равен " + Math.Cos(corner / 180));
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите длинны сонований и высоты");
            double x30;
            double perimeter;
            double footing1;
            double footing2;
            double height;
            int score = 1;
            do
            {
                Console.WriteLine("Введите значение основания1");
                footing1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение основания2");
                footing2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение высоты");
                height = double.Parse(Console.ReadLine());
                double sidebase = (Math.Max(footing1, footing2) - Math.Min(footing1, footing2)) / 2;
                perimeter = (2 * Math.Sqrt((height * height) + (sidebase * sidebase)) + footing1 + footing2);
                x30 = side(footing1, footing2, height);
                score += 1;
                if (score > 1 && x30 == 1)
                {
                    Console.WriteLine("Вы ввели некоректные значения. Ведите коректные значения");
                }
            }
            while (x30 == 1);
            Console.WriteLine("Если трапеция равнобедренная ,то ее периметр равен " + perimeter);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Зфдание 9");
            Console.WriteLine("Введите массу купленных товаров. В очередности конфеты, печенье, яблоки\r\nБудем считать что стоимость товаров такова\r\nКонфеты : 142\r\nПеченье : 87\r\nЯблоки : 234");
            double count1 = double.Parse(Console.ReadLine());
            double count2 = double.Parse(Console.ReadLine());
            double count3 = double.Parse(Console.ReadLine());
            double chek = 142 * count1 + 87 * count2 + 234 * count3;
            Console.WriteLine("Чек " + chek);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            string k1 = "Мир";
            string k2 = "Труд";
            string k3 = "Май";
            Console.WriteLine("{0,0}\r\n{1, 8}\r\n{2, 12}", k1, k2, k3);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 11");
            Console.WriteLine("Введите два числа");
            string timehouse;
            string alphabet = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю";
            string chisl1 = Console.ReadLine();
            string chisl2 = Console.ReadLine();
            int controlchisl = 0;
            for (int i = 0; i < chisl1.Length; i++)
            {
                //if (chisl1[i] == Convert.ToChar(".")) необходимо использовать не строки 
                //{
                //  chisl1[i] = Convert.ToChar(",");
                //}
                for (int g = 0; g < alphabet.Length; g++)
                {
                    if (chisl1[i] == alphabet[g])
                    {
                        controlchisl = 1;
                        break;
                    }

                }
                if (controlchisl == 1)
                {
                    Console.WriteLine("Вы ввели недопустимый символ");
                    break;
                }
            }
            timehouse = chisl1;
            chisl1 = chisl2;
            chisl2 = timehouse;
            Console.WriteLine(chisl1 + chisl2);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 12");
            Console.WriteLine("Что будем вычислять? Площадь или периметр?\r\n Для выбора площади введите 1 \r\n Для выбора периметра введите 2");
            int areaperimeter = int.Parse(Console.ReadLine());
            Console.WriteLine("Какая фигура будет в центре нашего внимания?\r\n Для выбора треугольника введите 1\r\n Для выбора четырехугольника введите 2\r\n Для выбора круга введите 3");
            int figure = int.Parse(Console.ReadLine());
            if (figure == 1)
            {
                Console.WriteLine("Введите длинны стороны и высоты треугольника . По очереди");
                double sidefigures1 = double.Parse(Console.ReadLine());
                double sidefigures2 = double.Parse(Console.ReadLine());
                if (areaperimeter == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (sidefigures1 * sidefigures2 / 2) + "\r\n  Для четырехугольника площадь равна " + (sidefigures1 * sidefigures2) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(sidefigures1, sidefigures2) * Math.Max(sidefigures2, sidefigures1)));
                }
                if (areaperimeter == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((sidefigures1 * sidefigures1) + (sidefigures2 * sidefigures2)) + sidefigures1 + sidefigures2) + "\r\n Для четырехугольника периметр равен " + (2 * (sidefigures1 + sidefigures2)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(sidefigures1, sidefigures2) * 2 * 3.14));
                }
            }
            if (figure == 2)
            {
                Console.WriteLine("Введите длинны сторон высоты четырехугольника . По очереди");
                double sidefigures1 = double.Parse(Console.ReadLine());
                double sidefigures2 = double.Parse(Console.ReadLine());
                if (areaperimeter == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (sidefigures1 * sidefigures2 / 2) + "\r\n  Для четырехугольника площадь равна " + (sidefigures1 * sidefigures2) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(sidefigures1, sidefigures2) * Math.Max(sidefigures2, sidefigures1)));
                }
                if (areaperimeter == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((sidefigures1 * sidefigures1) + (sidefigures2 * sidefigures2)) + sidefigures1 + sidefigures2) + "\r\n Для четырехугольника периметр равен " + (2 * (sidefigures1 + sidefigures2)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(sidefigures1, sidefigures2) * 2 * 3.14));
                }
            }
            if (figure == 3)
            {
                Console.WriteLine("Введите длинну диаметра");
                double sidefigures1 = double.Parse(Console.ReadLine());
                double sidefigures2 = 0.5 * sidefigures1;
                if (areaperimeter == 1)
                {
                    Console.WriteLine("Для треугольника площадь равна " + (sidefigures1 * sidefigures2 / 2) + "\r\n  Для четырехугольника площадь равна " + (sidefigures1 * sidefigures2) + "\r\n Для круга площадь равна " + (3.14 * Math.Max(sidefigures1, sidefigures2) * Math.Max(sidefigures2, sidefigures1)));
                }
                if (areaperimeter == 2)
                {
                    Console.WriteLine("Для переметр треугольника равен " + (Math.Sqrt((sidefigures1 * sidefigures1) + (sidefigures2 * sidefigures2)) + sidefigures1 + sidefigures2) + "\r\n Для четырехугольника периметр равен " + (2 * (sidefigures1 + sidefigures2)) + "\r\n Для круга периметр равен " + (0.5 * Math.Max(sidefigures1, sidefigures2) * 2 * 3.14));
                }
            }
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 13");
            Console.WriteLine("Введите число");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + x);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 14\r\n2 кг\r\n13 17");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 15");
            Random elem = new Random();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(elem.NextDouble());
            }
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 16");
            Console.WriteLine("Введите коэффиценты для квадратного уравнения ");
            Console.WriteLine("Введите значение коэффицента a ");
            double kf_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение коэффицента b ");
            double kf_b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение коэффицента c ");
            double kf_c = double.Parse(Console.ReadLine());
            Console.WriteLine("Уравнение имеет вид " + kf_a + "x^2 + (" + kf_b + "x) + (" + kf_c + ") = 0");
            double D = kf_b * kf_b - 4 * kf_a * kf_c;//Дискриминант
            if (D >= 0)
            {
                Console.WriteLine("Уравнение имеет корни:");
                Console.WriteLine("x1 = " + ((-kf_b) + Math.Sqrt(D)) / (2 * kf_a));//Корни
                Console.WriteLine("x2 = " + ((-kf_b) - Math.Sqrt(D)) / (2 * kf_a));
            }
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имет корней");
            }
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 17");
            int onechisl = 102;
            int twochisl = 193;
            Console.WriteLine("известны два числа: " + onechisl + ";" + twochisl + "\r\nИх среднее арифметическое равно " + ((onechisl + twochisl) * 0.5) + "\r\nИх среднее геометрическое равно " + (twochisl * onechisl * 0.5));
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 18");
            Console.WriteLine("Известны координаты точек A и В \r\nКоординаты точки А (2324;924)\r\nКоординаты точки В (752;223)");
            Console.WriteLine("Расстояние между точками равно " + Math.Sqrt(((2324 - 252) ^ 2) + ((924 - 223) ^ 2)));
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 19\r\nЧасть a");
            int a = 15;
            int b = 99;
            int c = 2362;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            int d = b;
            b = c;
            c = a;
            a = d;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Часть б");
            a = 15;
            b = 99;
            c = 2362;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            d = b;
            b = a;
            a = c;
            c = d;
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 20");
            Console.WriteLine("Введите значение n");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Прошло " + (time / 3600) + " часов " + ((time % 3600) / 60) + " минут " + (time / 60) + " секунд");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 21");
            Console.WriteLine("Из прямоугольника размером 130*543 можно вырежать " + 543 / 130 + " квадратов размером 130*130");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 22");
            int beginchisl = 285;
            Console.WriteLine("Начальное число " + beginchisl);
            string endchisl = Convert.ToString(beginchisl % 10) + Convert.ToString(beginchisl / 10);
            Console.WriteLine("Конечное число " + endchisl);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 23");
            Console.WriteLine("Введите число n, где n > 999");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("В числе " + number + " Содержется " + (number / 100) + " сотен и " + (number / 1000) + " тысяч");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 24");
            Console.WriteLine("Введите четырехзначное число");
            int four_numbers = int.Parse(Console.ReadLine());
            string strfournumbers = Convert.ToString(four_numbers);
            if (strfournumbers.Length == 4)
            {
                Console.WriteLine("число, полученное при прочтении его цифр справа налево " + strfournumbers[3] + strfournumbers[2] + strfournumbers[1] + strfournumbers[0]);
                Console.WriteLine("число, образуемое при перестановке первой и второй, третьей и четвертой цифр " + strfournumbers[1] + strfournumbers[0] + strfournumbers[3] + strfournumbers[2]);
                Console.WriteLine("число, образуемое при перестановке второй и третьей цифр " + strfournumbers[0] + strfournumbers[2] + strfournumbers[1] + strfournumbers[3]);
                Console.WriteLine("число, образуемое при перестановке двух первых и двух последних цифр " + strfournumbers[2] + strfournumbers[3] + strfournumbers[0] + strfournumbers[1]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вы ввели не четырехзначное число");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 25");
            Console.WriteLine("Введите число n . n должго принадлежать отрезку [100;999] ");
            string m = Console.ReadLine();
            Console.WriteLine("Искомое число x = " + m[2] + m[0] + m[1]);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 26");
            Console.WriteLine("Введите время. По очереди( часы, минуты, секунды,)");
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (hour > 11)
            {
                hour -= 12;
            }
            double pasttime = ((360 / 12) * hour + (0.5 * minutes) + (0.0083 * seconds));
            Console.WriteLine("Сейчас угол между положением стрелки на начало дня и временем ввреденным вами равен " + pasttime);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 28");
            Console.WriteLine("Введите три вещественных числа . По очереди ");
            List<double> chisl = new List<double>();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            chisl.AddRange(new double[]
                {
                    Math.Abs(num1),
                    Math.Abs(num2),
                    Math.Abs(num3)
                }
                           );
            int endnum = 0;
            if (chisl.Max() == Math.Abs(num1))
            {
                endnum = num1;
            }
            if (chisl.Max() == Math.Abs(num2))
            {
                endnum = num2;
            }
            if (chisl.Max() == Math.Abs(num3))
            {
                endnum = num3;
            }
            Console.WriteLine("Наибольшее по модулю число это " + endnum);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            List<double> nums = new List<double>();
            Console.WriteLine("Задание 29\r\nВведите три числа");
            nums.Add(double.Parse(Console.ReadLine()));
            nums.Add(double.Parse(Console.ReadLine()));
            nums.Add(double.Parse(Console.ReadLine()));
            Console.WriteLine("Сумма большего и меньше из трех заданных чисел равна " + (nums.Max() + nums.Min()));
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 30\r\nВведите число ,у которого будет вычисляться количество делителей");
            int countdelit = 2;
            int divisiblenumber = int.Parse(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(divisiblenumber); i++)
            {
                if (i == Math.Sqrt(divisiblenumber))
                {
                    countdelit++;
                }
                if (divisiblenumber % i == 0)
                {
                    countdelit += 2;
                }
            }
            Console.WriteLine("У числа " + divisiblenumber + ", " + countdelit + " делителей(ля)");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 31\r\nВедите коэфицинты уравнения третей степени");
            List<double> roots = new List<double>();
            double kfa = double.Parse(Console.ReadLine());
            double kfb = double.Parse(Console.ReadLine());
            double kfc = double.Parse(Console.ReadLine());
            double kfd = double.Parse(Console.ReadLine());
            int root = -100;
            do
            {
                if ((kfa * Math.Pow(root, 3) + (kfb * Math.Pow(root, 2)) + (kfc * root) + kfd) == 0)
                {
                    roots.Add(root);
                }
            }
            while (root == 101);
            string str1 = "имеет " + Convert.ToString(roots.Count) + " корней";
            string str2 = "не имет корней";
            string str3;
            if (roots.Count > 0)
            {
                str3 = str1;
            }
            else
            {
                str3 = str2;
            }
            Console.WriteLine("Уравнение " + kfa + "x^3 + (" + kfb + "x^2) + (" + kfc + "x) + (" + kfd + ") " + str3 + " на участке [-100;100]");
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 32");
            Console.WriteLine("Введите первый элемент последовательности");
            double sequence1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности");
            double sequence2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
            double numssequence = double.Parse(Console.ReadLine());
            double elementsequence = sequence1 + ((sequence2 - sequence1) * (numssequence - 1));
            Console.WriteLine("Элемент последовательности с номером " + numssequence + " равен " + elementsequence);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Задание 33");
            Console.WriteLine("Отметьте на вопросы");
            Console.WriteLine("Являетесь ли вы пенсионером? (1 - да , 0 - нет)");
            int pensioners = int.Parse(Console.ReadLine());
            Console.WriteLine("Являетесь ли вы студентом? (1 - да , 0 - нет)");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы тродоустроены? (1 - да , 0 - нет)");
            int x38 = int.Parse(Console.ReadLine());
            if (((pensioners == 1 && x38 == 0) || (student == 1 && x38 == 0)) && (pensioners == 0 || student == 0))
            {
                Console.WriteLine("Поздравляю вам одобрен кредит в ООО 'Тинькофф Банк'\r\nВЫ Можете связаться с нами по бесплатному телефону 8 800 555-777-8");
            }
            else
            {
                Console.WriteLine("К сожалению вам не одобрен кредит в нашем банке");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 34\r\nВведите свое имя ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Привет " + name);
            Console.WriteLine(transition);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 35");
            Random color = new Random();
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name2 = Console.ReadLine();
            Console.WriteLine("Привет, " + name2);
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            int color1 = color.Next(1, 15);
            if (color1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (color1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            if (color1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (color1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            if (color1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (color1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            if (color1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (color1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (color1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            if (color1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (color1 == 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (color1 == 11)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            if (color1 == 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (color1 == 13)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (color1 == 14)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (color1 == 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            Console.WriteLine(transition);
            Console.Clear();
            System.Threading.Thread.Sleep(5000);
            Console.ReadKey();

            Console.WriteLine("Задание 36\r\nЧасть а\r\nВВедите штрихкод");
            double notRoundcontrsum = 0;
            double controlsum;
            string barcode = (Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                if (i % 2 == 1)
                {
                    notRoundcontrsum += int.Parse(char.ToString(barcode[i]));
                }
                else
                {
                    notRoundcontrsum += 3 * int.Parse(char.ToString(barcode[i]));
                }
                controlsum = (10 * Math.Round((notRoundcontrsum + 5) / 10)) - notRoundcontrsum;
                Console.WriteLine("Контрольная сумма равна " + controlsum);
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Часть б");
                notRoundcontrsum = 0;
                Random barcode2 = new Random();
                string strbarcode2 = "";
                int elementbarcode2;
                for (i = 0; i < 12; i++)
                {
                    if (i % 2 == 1)
                    {
                        elementbarcode2 = barcode2.Next(0, 10);
                        notRoundcontrsum += elementbarcode2;
                        strbarcode2 += elementbarcode2.ToString();
                    }
                    else
                    {
                        elementbarcode2 = barcode2.Next(0, 10);
                        notRoundcontrsum += 3 * elementbarcode2;
                        strbarcode2 += elementbarcode2.ToString();
                    }
                }
                controlsum = (10 * Math.Round((notRoundcontrsum + 5) / 10)) - notRoundcontrsum;
                Console.WriteLine("Контрольная сумма штрихкода " + strbarcode2 + " равна " + controlsum);
                Console.WriteLine(transition);
                Console.ReadKey();

            }
        }
    }
}
