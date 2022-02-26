
using My.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson1
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
            //Задание первое

            Console.Title = "Анкета"; //название окна

            Console.Write("Введите свое имя: ");
            string Im = Console.ReadLine();
            
            Console.Write("Введите свою фамилию: ");
            string Fam = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            string Voz = Console.ReadLine();

            Console.Write("Введите свой вес в кг: ");
            string Ves = Console.ReadLine();

            Console.Write("Введите свой рост см: ");
            string Rost = Console.ReadLine();

            // Вывод информации на экран

            Console.WriteLine(Im + " " + Fam + " " + "в возрасте " + Voz + " весом " + Ves + " кг" + " ростом " + Rost + " см");
            Console.WriteLine("{0} {1} в возрасте {2} весом {3} кг ростом {4} см", Im, Fam, Voz, Ves, Rost);
            Console.WriteLine($"{Im} {Fam} в возрасте {Voz} весом {Ves} кг ростом {Rost} см");

            Console.ReadLine();


            //Задаие 2

            Console.Clear(); //Очищаем консоль

            Console.Title = "Идекс массы тела"; //название окна

            //Ввод первоначальных данных
            
            Console.Write("Пожалуйсто введите свой вес в кг. : ");
            int m = int.Parse(Console.ReadLine()); //Вводим вес
            Console.Write("Пожалуйсто введите свой рост в метрах(через запятую): ");
            double h = double.Parse(Console.ReadLine()); //Вводим рост
            
            double i = m / (h * h); //Расчитываем идекс массы тела
            
            // Вывод информации на экран

            Console.WriteLine($"Идекс массы тела {i:f2}");

            Console.ReadLine();


            //Задаие 3    

            Console.Clear(); //Очищаем консоль

            Console.Title = "Расстояние между точками"; //название окна

            //Ввод первоначальных данных

            //Вводим координаты первой точки
            Console.WriteLine("Пожалуйсто введите координаты первой точки: ");
            Console.Write("Введите X: ");
            double x1 = double.Parse(Console.ReadLine()); // Коодинаты X

            Console.Write("Введите Y: ");
            double y1 = double.Parse(Console.ReadLine()); // Координыты Y

            //Вводим координатыв второй точки
            Console.WriteLine("Пожалуйсто введите координаты второй точки: ");
            Console.Write("Введите X: ");
            double x2 = double.Parse(Console.ReadLine()); // Коодинаты X
            //
            Console.Write("Введите Y: ");
            double y2 = double.Parse(Console.ReadLine()); //Координыты Y



            // double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //Расчитываем  результат

            // Вывод информации на экран
            //Console.WriteLine($"Расстояние между двумя точками  {r:f2}");

            Console.WriteLine($"Расстояние между точками {CountDistance(x1, y1, x2, y2):F2}" );// Ввывод информации на экран, и расчет через метод



            Console.ReadLine();


            /* Задание 4
                Написать программу обмена значениями двух переменных:
                а) с использованием третьей переменной;
                б) *без использования третьей переменной.
                 */

            Console.Clear(); //Очищаем консоль

            Console.Title = "Мухлюем с переменными"; //название окна
            
            //Вариант "а"
            //Объявляем переменные
            int x = 12, y = 8, z;
            Console.WriteLine($"\nИсходные значения переменных x = {x}, y = {y}");

            //Сохраняем значение x в переменную z
            z = x;
            //Меняем х и у местами
            x = y; y = z;
            Console.WriteLine($"Значения переменных после обмена x = {x}, y = {y}");

            //Вариант "б" (решение только для числовых значений, для неисловых нагуглил (x, y) = (y, x), но мы это пока не проходили :)
            //Возвращаем значения переменных к исходным
            x = 12; y = 8;
            Console.WriteLine($"\nИсходные значения переменных x = {x}, y = {y}");

            //Меняем х и у местами
            x += y;
            y = x - y;
            x -= y;
            Console.WriteLine($"Значения переменных после обмена x = {x}, y = {y}");

           Utils.Pause();


            //Задание 5

            Console.Clear(); //Очищаем консоль

            Console.Title = "Выод информации в центр консоли"; //название окна

            string msg = "Студент: Стольник Ярослав, город: Копейск";
            //Вариант "а"
            Console.WriteLine("\n" + msg);

            Utils.Pause();

            //Вариант "б" и "в"
            //Очищаем консоль
            Console.Clear();

            //используем собственный метод для вывода текста на экран, центр определяем поделив длину консоли пополам и вычитаем половину длины печатаемой строки
            Utils.Print(msg, Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);


            Utils.Pause();
        }

        /// <summary>
        /// Рассчитывает расстояния по координатам двух точек
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double CountDistance(double x1, double y1, double x2, double y2)
        {
           return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        /// <summary>
        /// Переносит курсор на заданную позицию и печатает текст, переданный в метод
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
       /* static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }
       */
        /// <summary>
        /// Метод для остановки программы и ожидания нажатия пользователем любой клавиши
        /// </summary>
       /* static void Pause()
        {
            Console.Write("\nНажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
        
        }
        */
    }
}
