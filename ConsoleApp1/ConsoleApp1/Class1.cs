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
    class ComplexClass
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


        public ComplexClass()
        {

        }

        public ComplexClass(double re, double im)
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
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }


        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        public ComplexClass Mnojim(ComplexClass x)
        {
            return new ComplexClass(re * x.re, im * x.im);
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

    internal class Sample03
    {
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


            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");
            Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Mnojim(complex02)}");

            Console.ReadLine();
        }
    }
}
