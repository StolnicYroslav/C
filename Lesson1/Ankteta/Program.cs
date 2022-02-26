using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexMas
{
    /// <summary>
    /// Главный класс
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Идекс массы тела"; //название окна

            //Ввод первоначальных данных

            Console.Write("Пожалуйсто введите свой вес в кг. : ");
            int m =int.Parse (Console.ReadLine()); //Вводим вес

            Console.Write("Пожалуйсто введите свой рост в метрах(через запятую): ");
            double h = double.Parse(Console.ReadLine()); //Вводим рост

            double i = m / (h * h); //Расчитываем идекс массы тела
            
            // Вывод информации на экран

            Console.WriteLine($"{i:f2}");

            Console.ReadLine();
        }

    }
}
