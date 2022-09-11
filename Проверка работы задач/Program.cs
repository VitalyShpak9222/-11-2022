using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_работы_задач
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Зфдание 9");
            Console.WriteLine("Введите массу купленных товаров. В очередности конфеты, печенье, яблоки \r\n Будем считать что стоимость товаров такова \r\n конфеты : 142 \r\n печенье : 87 \r\n nяблоки : 234");
            double z1 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double z3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Чек " + (z1 * 142) + (z2 * 87) + (z3 * 234));
        }
    }
}
 