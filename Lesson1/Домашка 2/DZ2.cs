/* 
Студент: Стольник Ярослав

Домашнее задание к уроку #2
1. Написать метод, возвращающий минимальное из трёх чисел.
2. Написать метод подсчета количества цифр числа.
3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.
5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
5. б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
7. б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

*/



using My.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка_2
{
    /// <summary>
    /// Оснавной класс
    /// </summary>
    internal class Lesson2
    {
        /// <summary>
        /// Метод main - точка старта программы
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            bool ShowMenu = true;
            while (ShowMenu)
            {
                Console.Clear(); //при входе в меню очищаем экран

                /*Console.Write("Введитие номер задания от 1 до 7, длля выхода введите 0: ");
                int selector = int.Parse(Console.ReadLine());
                */

                //используем собственный метод для вывода текста на экран, центр определяем поделив длину консоли пополам и вычитаем половину длины печатаемой строки
                //Utils.Print(msg, Console.WindowWidth / 2 - msg.Length / 2, Console.WindowHeight / 2);

                
                Console.WriteLine("                       Мои задачи");
                Console.WriteLine("========================================================");
                Console.WriteLine("1 -> Определяем минимальное число");
                Console.WriteLine("2 -> Количество цифр введенного числа");
                Console.WriteLine("3 -> Сумма введенных нечетных положительных чисел");
                Console.WriteLine("4 -> Проверка логина и пароля для входа");
                Console.WriteLine("5 -> Индекс массы тела");
                Console.WriteLine("6 -> Считаем хорошие числа в диапазоне 1 до 1 000 000 000");
                Console.WriteLine("7 -> Изучаем рекурсию");
                Console.WriteLine("\n0 -> Завершение работы приложения");
                Console.WriteLine("========================================================");

                Console.Write("Введите номер задачи: ");
                int work = int.Parse(Console.ReadLine());

                switch (work)
                {
                    //Задача 1
                    case 1:

                        double a1, a2, a3;    //Объявление переменных
                                                
                        Console.WriteLine("\nВведите три числа, программа выведет минимальное из них: ");
                        Console.Write("Введите первое число: ");
                        a1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nВведите три числа, программа выведет минимальное из них: ");
                        Console.Write("Введите первое число: ");
                        a2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nВведите три числа, программа выведет минимальное из них: ");
                        Console.Write("Введите первое число: ");
                        a3 = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nМинимальное число: " + MinNumbers(a1,a2,a3));
                        Utils.Pause();
                        break;

                    //Задача 2
                    case 2:
                        Console.WriteLine("\nВведите целое положительное или отрицательное число: ");
                        Console.WriteLine("Количество цифр введенного числа: {0}", GetNumberLength(long.Parse(Console.ReadLine())));
                        Utils.Pause();
                        break;

                    //Задача 3
                    case 3:
                        Console.WriteLine("\nВводите целые числа, при вводе 0 программа подсчитает сумму введенных нечетных положительных чисел");
                        Console.WriteLine("Сумма введенных нечетных положительных чисел: {0}", SumPositive());
                        Utils.Pause();
                        break;

                    //Задача 4
                    case 4:
                        
                        string login, password;
                        int PasswordEntryAttempt = 0;
                        
                        Console.WriteLine("Введите логин и пароль для входа в систему.");


                        do
                        {
                            PasswordEntryAttempt++;
                            Console.WriteLine("\nПопытка ввода пароля #{0}", PasswordEntryAttempt);
                            Console.Write("Введите логин: ");
                            login = Console.ReadLine();

                            Console.Write("Введите пароль: ");
                            password = Console.ReadLine();

                            if (CheckPassword(login, password))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Логин и пароль верный, вы зашли в систему");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {
                                if (PasswordEntryAttempt < 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Ошибка при вводе логина или пароля, вы можете попробовать еще " + (3 - PasswordEntryAttempt) + " раз.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Вы исчерпали количество попыток ввода.");
                                    Console.ForegroundColor = ConsoleColor.White;
                            }

                        }
                        while (CheckPassword(login, password) == false && PasswordEntryAttempt < 3);

                        Utils.Pause();
                        break;

                    //Задача 5
                    case 5:
                        IndexMassTela();
                        Utils.Pause();
                        break;

                    //Задача 6
                    case 6:
                        DateTime Start = DateTime.Now;
                        Console.WriteLine("Идет расчет...");

                        long GoodsNumbers = 0;
                        

                        for (long i = 1; i <= 1000000000; i++)                       
                        
                            if (i % RecursiveDigitSum(i) == 0) GoodsNumbers++;

                       // DateTime Finish = DateTime.Now;

                        Console.WriteLine("Программа выполнялась " + (DateTime.Now - Start));  //Расччет времени выполнения программы

                                                    
                        Console.WriteLine($"{GoodsNumbers:N0} \"хороших\" числа в диапазоне от 1 до 1 000 000 000.");

                        Utils.Pause();
                        break;

                    //Задача 7
                    case 7:
                        int a, b;
                        Console.WriteLine("Введите число а: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите число b, где b > a: ");
                        b = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nВыводим на экран все числа от a до b при помощи рекурсивного метода:");
                        RecursiveWriteAtoB(a, b);
                        Console.WriteLine("\nСумируем числа от a до b при помощи рекурсивного метода: " + RecursiveSumAtoB(a, b));

                        Utils.Pause();
                        break;

                    //Выход из программы
                    case 0:
                        ShowMenu = false;
                        Console.WriteLine("Выход из программы");
                        break;

                    //Отрабатываем ошибку при вводе пункта меню
                    default:
                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                        Utils.Pause();
                        break;
                }
            }
        }

        /// <summary>
        /// Возвращает минимальное из 3 чисел
        /// </summary>
        /// <param name="x">Число 1</param>
        /// <param name="y">Число 2</param>
        /// <param name="z">Число 3</param>
        /// <returns></returns>
        static double MinNumbers(double x, double y, double z)
        {
            if (x <= y || x <= z) return x;
            else
            {
                if (y <= z) return y;
                else return z;
            }
        }

        /// <summary>
        /// 2Возвращает количество
        /// </summary>
        /// <param name="number">Число для анализа</param>
        /// <returns>Возвращает количество цифрв положительного или отрицательного целого числа</returns>
        static int GetNumberLength(long number)
        {
            return (number == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(number) + 0.5));


            
        }

        /// <summary>
        /// Запрашивает ввод чисел. При вводе нуля подсчитывает количество введенных положительных нечетных чисел.
        /// </summary>
        /// <returns></returns>
        static int SumPositive()
        {
            
            int sum = 0;
            int num1;
            
            do
            {
                num1 = int.Parse(Console.ReadLine());
                sum += num1 > 0 && num1 % 2 == 1 ? num1 : 0;
            } while (num1 != 0);

            
            return sum;

        }

        /// <summary>
        /// Возвращает информацию о том, корректны или нет введенные логин и пароль
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        static bool CheckPassword(string login, string pass)
        {
            return (login == "root" && pass == "GeekBrains") ? true : false;
        }

        /// <summary>
        /// Запрашивает данные о человеке, рассчитывает индекс массы тела и выводит рекомендации по диете.
        /// </summary>
        static void IndexMassTela()
        {
            double mass, height, massIndex;
            Console.WriteLine("Введите массу человека в килограммах: ");
            mass = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост человека в сантиметрах: ");
            height = double.Parse(Console.ReadLine()) / 100;
            massIndex = mass / (height * height);
            Console.Write("Индекс массы тела = {0:F2}. ", massIndex);

            if (massIndex < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nВыраженный дефицит массы тела, ешь котлеты и пюре.\nДля нормализации нужно набрать минимум {0:F2} кг.", 18 * (height * height) - mass);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                if (massIndex < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Масса тела в норме.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (massIndex < 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\nИзбыточная масса тела, пора худеть.\nДля нормализации нужно сбросить минимум {0:F2} кг.", mass - 25 * (height * height));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\nСлишком большой вес, опасно для жизни, срочно на диету.\nДля нормализации нужно сбросить минимум {0:F2} кг.", mass - 25 * (height * height));
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает сумму цифр числа, рекурсивный метод
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static long RecursiveDigitSum(long number)
        {
            if (number == 0) return 0;
            else return (number % 10 + RecursiveDigitSum(number / 10));
        }

        /// <summary>
        /// Выводит на экран числа от a до b через рекурсию
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void RecursiveWriteAtoB(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                RecursiveWriteAtoB(a + 1, b);
            }
        }

        /// <summary>
        /// Возвращает сумму всех чисел между a и b включительно
        /// </summary>
        /// <param name="a">Число a</param>
        /// <param name="b">Число b</param>
        /// <returns></returns>
        static int RecursiveSumAtoB(int a, int b)
        {
            if (a <= b) return (a + RecursiveSumAtoB(a + 1, b));
            else return 0;
        }

       


    }

}

