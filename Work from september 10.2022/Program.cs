using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_from_september_10._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.1 Тумаков");
            Console.WriteLine("Как вас зовут ?");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);
            Console.WriteLine("Для продолжения нажмите на любую клавишу");
            Console.ReadLine();

            Console.WriteLine("задание 2.2 Тумаком");
            Console.WriteLine("Введите два целых числа");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x / y);
            Console.WriteLine("Для продолжения нажмите на любую клавишу");
            Console.ReadLine();

            Console.WriteLine("Задание 2.3 Тумаков");
            Console.WriteLine("Ввкдите одину букв.лат.алфавита");
            string bukv = Console.ReadLine();
            

            Console.WriteLine("Задание 2.4 Тумаков");
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
                Console.WriteLine("x1 = " + ((-b) + Math.Sqrt(d)) / (2*a));
                Console.WriteLine("x2 = " + ((-b) - Math.Sqrt(d)) / (2 *a));
            }
            if (d < 0)
            {
                Console.WriteLine("Уравнение не имет корней");
            }
            Console.ReadKey();
            
        }
    }
}
