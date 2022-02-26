using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            string imya, famil, voz, rost, ves;
            double voz1, ves1;
            double rost1;

            Console.WriteLine("Введите данные подопытного: ");


            Console.Write("Введите Имя: ");
            imya = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            famil = Console.ReadLine();

            Console.Write("Введите возраст: ");
            voz = Console.ReadLine();

            Console.Write("Введите рост в метрах, через запятую: ");
            rost = Console.ReadLine();

            Console.Write("Введите вес в кг: ");
            ves = Console.ReadLine();


            Console.WriteLine(imya + " " + famil + " в возрасте " + voz + " лет " + "ростом " + rost + " весом " + ves);
            Console.WriteLine("{0} {1} в возрасте {2} лет ростом {3} весом {4}", imya, famil, voz, rost, ves);
            Console.WriteLine($"{imya} {famil} в возрасте {voz} лет ростом {rost} весом {ves}");


            voz1 = double.Parse(voz);
            ves1 = double.Parse(ves);
            rost1 = double.Parse(rost);

            double index = ves1 / (rost1 * rost1);

            Console.WriteLine("Индекс массы тела: " + index);
            

            int x1 = 2, y1 = 2, x2 = 5, y2 = 5;
            double rez;
            string msg="Расстояние между точками ";

            Print(msg, rez=rastoyanie(x1, y1, x2, y2));

            Console.ReadLine();


        }

        static double rastoyanie(int x1, int y1, int x2, int y2)
        {

            double rez = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return (rez);
        }
        static void Print(string msg, double rez)
        {
            Console.WriteLine(msg+rez);

        }

    }
}
