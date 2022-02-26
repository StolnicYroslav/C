using System;
using System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Замена_переменных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Задание 4
                Написать программу обмена значениями двух переменных:
                а) с использованием третьей переменной;
                б) *без использования третьей переменной.
                 */

            //Вариант "а"
            //Объявляем переменные
            int x = 3, y = 7, z;
            Console.WriteLine($"\nИсходные значения переменных x = {x}, y = {y}");

            //Сохраняем значение x в переменную z
            z = x;
            //Меняем х и у местами
            x = y; y = z;
            Console.WriteLine($"Значения переменных после обмена x = {x}, y = {y}");

            //Вариант "б" (решение только для числовых значений, для неисловых нагуглил (x, y) = (y, x), но мы это пока не проходили :)
            //Возвращаем значения переменных к исходным
            x = 3; y = 7;
            Console.WriteLine($"\nИсходные значения переменных x = {x}, y = {y}");

            //Меняем х и у местами
            x += y;
            y = x - y;
            x -= y;
            Console.WriteLine($"Значения переменных после обмена x = {x}, y = {y}");
            Pause();
        }

        /// <summary>
        /// Метод для остановки программы и ожидания нажатия пользователем любой клавиши
        /// </summary>
        static void Pause()
        {
            Console.Write("\nНажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
        }
    }
}
