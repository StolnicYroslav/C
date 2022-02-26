using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число:");
            int value =Convert.ToInt32( Console.ReadLine());
            

            Console.WriteLine(Odd(value));
            Console.ReadLine();

            Print("Привет!\n", 10, 10);
            Print("Привет еще раз!", ConsoleColor.Red);
            Console.ReadLine();

//Задача про треугольник 
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle(a, b, c));
            Console.WriteLine("Площадь треугольника:" + S(a, b, c));
            Console.ReadLine();

        }


        static bool Odd(int n)
        {
            if (n % 2 == 0)
            {
                
                Print("Введенное число " + n + " было четным",ConsoleColor.Green);
                
                return true;

            }
            else
            {
                Print("Введенное число " + n + " было не четным",ConsoleColor.Red);
       
                return false;
            }
        }


       

        static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;

            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        
        static bool IsTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && c + b > a;
        }

        static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }




    }
}
