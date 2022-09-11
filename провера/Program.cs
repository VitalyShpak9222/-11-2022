using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace провера
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();  // Строка
            byte[] tmp = Encoding.Unicode.GetBytes(str);    // получаем коды Unicode
            string outStr = BitConverter.ToString(tmp).Replace("-", " ");
            string hex = outStr;
            byte[] buf = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                buf[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            string s = Encoding.BigEndianUnicode.GetString(buf);
            Console.ReadLine();
            
        }
    }
}
