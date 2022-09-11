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

            Console.WriteLine("Задание 2");
            Console.WriteLine("50");
            Console.WriteLine("10");
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 3");
            Random x = new Random();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(x.NextDouble());
            }
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите свое число");
            double x2 =  double.Parse(Console.ReadLine());
            Console.WriteLine(x2 + 10);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число равное стороне квадрата");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр квадрата со стороной указанной вами равен " + n * 4);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите длинну радиуса окружности");
            double r = double.Parse(Console.ReadLine());
            double l = 2 * 3.14 * r;
            double p = 3.14 * r * r;
            Console.WriteLine("Длина окружности равна " + l );
            Console.WriteLine("Площадь окружности равна " + p);
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 7");
            Console.WriteLine("Введите градусную величену угла");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Косигус угла равен " + Math.Cos(x4));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите длинны сонований и высоты в очередности: основание1, основани2, высота ");
            double d1 = double.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double x5 = Math.Max(d1 , d2) - Math.Min(d1, d2);
            Console.WriteLine("Периметр трапеции равен " + (2*Math.Sqrt((h * h) + (x5 * x5)) + d1 + d2));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();

            Console.WriteLine("Зфдание 9");
            Console.WriteLine("Введите массу купленных товаров. В очередности конфеты, печенье, яблоки \r\n Будем считать что стоимость товаров такова \r\n конфеты : 142 \r\n печенье : 87 \r\n nяблоки : 234");
            double z1 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double z3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Чек " + (z1 * 142) + (z2 * 87) + (z3 * 234));
            Console.WriteLine("Для продолжения нажмите на Enter");
            Console.ReadKey();
        }
    }
}
