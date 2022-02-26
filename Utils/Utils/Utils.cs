using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Utils
{
    public class Utils
    {
        /// Метод для остановки программы и ожидания нажатия пользователем любой клавиши
        /// </summary>
        public static void Pause()
        {
            Console.Write("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();

        }




        /// <summary>
        /// Переносит курсор на заданную позицию и печатает текст, переданный в метод
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }


        /*public static int Endstr(int x)
        {
            
            Console.WriteLine("Введите возраст, до 50 лет:");
            x = int.Parse(Console.ReadLine());
            string s = "Вам " + x;
            // Год - когда заканчивается на один, кроме 11.
            if (x % 10 == 1 && x != 11) s += " год";
            else
                // Года
                if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " года";
            return s.Length;
                    // Лет
                    if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " лет";

            Console.WriteLine(s);
        
        } */
    }




}
