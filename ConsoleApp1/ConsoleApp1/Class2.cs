using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    class ComplexClass01
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        public double Re
        {
            get
            {
                return re;

            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("На ноль делить нелья!");
                }
                re = value;
            }
        }


        public ComplexClass01()
        {

        }

        public ComplexClass01(double re, double im)
        {
            if (re == 0)
            {
                throw new Exception("На ноль делить нелья!");
            }

            this.re = re;
            this.im = im;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass01 Plus(ComplexClass01 x)
        {
            return new ComplexClass01(re + x.re, im + x.im);
        }


        public ComplexClass01 Minus(ComplexClass01 x)
        {
            return new ComplexClass01(re - x.re, im - x.im);
        }

        public ComplexClass01 Mnojim(ComplexClass01 x)
        {
            return new ComplexClass01(re * x.re, im * x.im);
        }

        public override string ToString()
        {

            if (im == 0) return $"{re} + {im}i";

            if (im > 0)
            {
                return $"{re} + {im}i";
            }
            else return $"{re} {im}i";
        }
    }

    internal class Sample04    {
        static void Main(string[] args)
        {
            ComplexClass complex01 = new ComplexClass(5, 3);
            //complex01.Re = 0;

            Console.WriteLine(complex01.Re);

            // complex01.re = 0;
            //complex01.im = 5;

            ComplexClass complex02 = new ComplexClass(3, -1);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            bool ShowMenu = true;
            while (ShowMenu)
            {
                Console.Clear(); //при входе в меню очищаем экран
                Console.WriteLine("                       Мои задачи");
                Console.WriteLine("========================================================");
                Console.WriteLine("1 -> Вывести сумму комплексных чисел");
                Console.WriteLine("2 -> Вывести разность  комплексных чисел");
                Console.WriteLine("3 -> Произведение сумму комплексных чисел");
                Console.WriteLine("\n0 -> Завершение работы приложения");
                Console.WriteLine("========================================================");

                Console.Write("Введите номер задачи: ");
                int work = int.Parse(Console.ReadLine());

                switch (work)
                {
                    //Задача 1
                    case 1:

                        Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
                        Console.ReadLine();

                        break;

                    case 2:
                        Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");
                        

                        Console.ReadLine();   

                        break;



                    case 3:
                        
                        Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Mnojim(complex02)}");

                        Console.ReadLine();

                        break;

                    //Выход из программы
                    case 0:
                        ShowMenu = false;
                        Console.WriteLine("Выход из программы");
                        break;

                    //Отрабатываем ошибку при вводе пункта меню
                    default:
                        Console.WriteLine("Ошибка ввода, попробуйте снова");
                        Console.ReadLine();
                        break;
                }
            }
        }

           // Console.ReadLine();
        }
    }

