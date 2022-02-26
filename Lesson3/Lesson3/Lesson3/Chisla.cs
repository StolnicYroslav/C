using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    internal class Utils
    {
        /// Метод для остановки программы и ожидания нажатия пользователем любой клавиши
        /// </summary>
        internal  static void Pause()
        {
            Console.Write("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();

        }
    }
        internal class Chisla
        {
        
            static void Main(string[] args)
            {
                Console.WriteLine("\nВводите целые числа, при вводе 0 программа \nподсчитает сумму введенных нечетных положительных чисел\n");
                Console.WriteLine("Сумма введенных нечетных положительных чисел: {0}", SumPositive());
                //Console.ReadLine();
                Utils.Pause();
            }

            static int SumPositive()
            {
                /*
                int sum = 0;
                int num1;

                do
                {
                    num1 = int.Parse(Console.ReadLine());
                    sum += num1 > 0 && num1 % 2 == 1 ? num1 : 0;
                } while (num1 != 0);


                return sum; 


                */
                int result = 0;
                var numbers = new List<int>();

                bool check = true;
                do
                {
                    Console.Write("Введите целое число:");

                    check = int.TryParse(System.Console.ReadLine(), out int number);

                    if (check)
                    {
                        if (number > 0 && number % 2 == 1)
                        {
                            result += number;
                            numbers.Add(number);
                        }
                        else if (number == 0)
                        {
                            check = false;
                        }
                    }
                }
                while (check);

                string s = "";
                for (int i = 0; i < numbers.Count; i++)
                {
                    s += ($"{numbers[i]};");
                }

                Console.WriteLine("\nНечетные и положительные числа: " + s);

                //Console.Write($"\nСумма введенных нечетных положительных чисел: {result};");



                return result;
            }
        }
    }

