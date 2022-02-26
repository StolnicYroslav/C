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
using System.IO;

namespace HomeWork4
{
    internal class ZD2b
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 34, -1, 4, -5 };
            MyArray myArray = new MyArray(arr);
            int[] array = new int[20]; ////Объявление массива длинной 20 элементов

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                array[i] = random.Next(-10000, 10001); //Заполняем массив псевдо случайными числами от -10000 до 10000
            }

            MyArray.findarray(array);  //передаем массив в класс MyArray методу myarray
                       
            MyArray myArray2 = new MyArray(AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt");
            
            myArray2.PrintArray();

            MyArray myArray3 = new MyArray(20, -25, 25);

            myArray3.PrintArray();
            
            Console.ReadLine();

        }
    }
    public class MyArray
    {
        #region Поля

        private int[] arr;
        

        #endregion
        #region Конструкторы
        public MyArray(int n, int min, int max)
        {
            arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max);
        }

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public MyArray(string fileName)
        {
            arr = LoadArrayFromFile(fileName);
        }

        
        #endregion
      
        #region Публичные методы 

        public int GetElement(int index)
        {
            return arr[index];
        }

        public void SetElement(int index, int value)
        {
            arr[index] = value;
        }

        public void PrintArray()
        {
            if (arr != null)
            {

                for (int i = 0; i < arr.Length; i++)
                {

                    Console.Write($"{arr[i]}\t");
                }
                Console.WriteLine();
                
            }
            
        }
        
        #endregion
        internal static int findarray(int[] array)
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

    
        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))  //Проверяем есть ли файл, и решаем как дальше жить
            {
                Console.WriteLine("Звиняйте Файл не существует, дальнейшая работа не возможна\n"+ fileName);
                
                return null;
            }

            Console.WriteLine("О боже Нам сопутствует удача и файл нашелся,\n будем его читать и заполнять массив\n" + fileName);

            int[] arr = new int[1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++;
            }

            int[] buf = new int[counter];

            Array.Copy(arr, buf, counter);

            sr.Close();
            return buf;
        }
    }
}


