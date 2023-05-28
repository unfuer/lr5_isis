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
            Console.WriteLine("\nК О Н С О Л Ь Н О Е   П Р И Л О Ж Е Н И Е   К А Л Ь К У Л Я Т О Р\nversion 0.1   developed by andrey cherepanov\n");
            Console.Write("Первое число: "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВторое число: "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВыберите действие:\n1. Сложить\n2. Вычесть\n3. Умножить\n4. Разделить\n\nДействие: "); c = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\nК О Н С О Л Ь Н О Е   П Р И Л О Ж Е Н И Е   К А Л Ь К У Л Я Т О Р\nversion 0.1   developed by andrey cherepanov\n");
            Console.WriteLine("Результат: ");
            if (c == 1) Console.WriteLine(a + " + " + b + " = " + (a + b) + "\n");
            if (c == 2) Console.WriteLine(a + " – " + b + " = " + (a - b) + "\n");
            if (c == 3) Console.WriteLine(a + " × " + b + " = " + (a * b) + "\n");
            if (c == 4) Console.WriteLine(a + " : " + b + " = " + (a / b) + "\n");
            return;
        }
    }
}
