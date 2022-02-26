/*          Студент Стольник Ярослав
          
    

2. Реализуйте задачу 1 в виде статического класса StaticClass;

а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;

б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;

в)*Добавьте обработку ситуации отсутствия файла на диске.

*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class ZD2
    {
        static void Main(string[] args)
        {
            int[] array = new int[20]; ////Объявление массива длинной 20 элементов

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-10000, 10001); //Заполняем массив псевдо случайными числами от -10000 до 10000
            }

            StaticClass.myarray(array);  //передаем массив в класс MyArray методу myarray
        }
    }
    static  class StaticClass
    {
        internal static int myarray(int[] array)
        {
            int count = 0;
            for (int x = 0; x < array.Length - 1; x++)

            {
                if (array[x] % 3 == 0 | array[x + 1] % 3 == 0) count++; //Ищем пары
                Console.WriteLine("Пара чисел: {0} и {1}", array[x], array[x + 1]);
            }
            Console.WriteLine("Количество пар: " + count);
            Console.ReadLine();

            return count;
        }

    
    }
    }
    

