using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_isis_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double c;
            Console.Write("Первое число: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nВыберите действие:\n1. Сложить\n2. Вычесть\n3. Умножить\n4. Разделить\n\nДействие: "); c = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Результат: ");
            if (c == 1) Console.WriteLine(a + " + " + b + " = " + (a + b) + "\n");
            if (c == 2) Console.WriteLine(a + " – " + b + " = " + (a - b) + "\n");
            if (c == 3) Console.WriteLine(a + " × " + b + " = " + (a * b) + "\n");
            if (c == 4) if (b != 0) Console.WriteLine(a + " : " + b + " = " + (a / b) + "\n"); else { Console.Clear(); Console.WriteLine("ОШИБКА 1:\nДеление на 0."); }
            return;
        }
    }
}
