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
            Console.Title = "Расстояние между точками"; //название окна

            //Ввод первоначальных данных
            
            //Вводим координаты первой точки
            Console.WriteLine("Пожалуйсто введите координаты первой точки: ");
            Console.Write("Введите X: ");
            int x1 = int.Parse(Console.ReadLine()); // Коодинаты X
            
            Console.Write("Введите Y: ");
            int y1 = int.Parse(Console.ReadLine()); // Координыты Y
            
            //Вводим координатыв второй точки
            Console.WriteLine("Пожалуйсто введите координаты второй точки: ");
            Console.Write("Введите X: ");
            int x2 = int.Parse(Console.ReadLine()); // Коодинаты X
            //
            Console.Write("Введите Y: ");
            int y2 = int.Parse(Console.ReadLine()); //Координыты Y



            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //Расчитываем  результат

            // Вывод информации на экран
            Console.WriteLine($"Расстояние между двумя точками  {r:f2}");

            Console.ReadLine();
        }

    }
}
