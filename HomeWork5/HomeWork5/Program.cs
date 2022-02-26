
/*
Студент: Стольник Ярослав AR/VR

1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) **с использованием регулярных выражений.

2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
Например: badc являются перестановкой abcd.

4. *Задача ЕГЭ.
На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. В первой строке сообщается количество учеников N, которое не меньше 10,
но не превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,

где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа,
соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. 

Пример входной строки:
Иванов Петр 4 5 3

Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Проверка корректности логина
            //от 2 до 10 символов, буквы латинского алфавита или цифры, цифра не может быть первой
            Console.WriteLine("Введите логин\nот 2 до 10 символов, буквы латинского алфавита или цифры,\nцифра не может быть первой");
            string login = Console.ReadLine();

            if (login == null)
            {

                bool flag1 = false;
                if (Char.IsDigit(login[0]) == false && login.Length <= 10 && login.Length >= 2)
                {
                    foreach (char ch in login)
                        if (Char.IsDigit(ch) == true || ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z') flag1 = true;
                        else
                        {
                            flag1 = false;
                            break;
                        }
                }

                bool flag2 = false;
                flag2 = Regex.IsMatch(login, "^[A-Za-z]{1}[0-9A-Za-z]{1,9}$");  //Проверка c использованием регулярных выражений

                Console.WriteLine("\nПроверка без использования регулярных выражений");
                if (flag1) Console.WriteLine("Введенный логин корректен");
                else Console.WriteLine("Ошибка ввода!");

                Console.WriteLine("\nПроверка c использованием регулярных выражений");
                if (flag2) Console.WriteLine("Введенный логин корректен");
                else Console.WriteLine("Ошибка ввода!");
            }

            else Console.WriteLine("Вы ни чего не ввели");


            Pause();

            Console.Clear();
            
            string text = "\n2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста: а) Вывести только те слова сообщения, которые содержат не более n букв. б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. в) Найти самое длинное слово сообщения. г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.";

            Console.WriteLine("Наше сообщение:\n" + text + "\n");
            Console.WriteLine("Вывод слов, содаржащих не более 4 букв: \n");
            Message.GetWordsOfLength(text, 4);


            Console.WriteLine("\n\nУдалим слова заканчивающиеся на какую букву?");

            char s= char.Parse(Console.ReadLine());

            Console.WriteLine("\n\nУдаляем из сообщения слова, заканчивающиеся на " + s+"\n");
            Message.RemoveWords(text, s);
            Console.WriteLine();

            Console.WriteLine("Самое длинное слово в сообщении:\n" + Message.GetLongestWord(text) + "\n");

            Message.GetAllLongestWords(text);
            Console.WriteLine();

            String[] Dictionary = { "класс", "текст", "слов", "для", "самолет", "автомобиль", "метод" };
            Message.FrequencyAnalysis(text, Dictionary);

            Pause();
        }
    public static void Pause()
        {

        
            Console.Write("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
        }

    }
    public static class Message
    {
        //private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "—", "_" };
        private static string[] separators = { " " };

        public static void GetWordsOfLength(string text, int length)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words) if (word.Length <= length) Console.Write(word + " ");
        }


        public static void RemoveWords(string text, char ending)
        {
            StringBuilder sb = new StringBuilder(text.Length);
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Реализация с помощью stringbuilder -режем на слова и пропускаем не нужные, проблема возникает со знаками препинания,
            //т.к.split их убирает, ищем другое решение
            //foreach (string word in words) if (word[word.Length - 1] != ending) sb.Append(word + " ");
            //Console.WriteLine(sb);

          //  Реализация через regex - OK!

            Regex regex = new Regex("\\w+" + ending + "\\b");
            text = regex.Replace(text, "");
            Console.WriteLine(text);
        }

        public static string GetLongestWord(string text)
        {
            string LongestWord = "";
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words) if (word.Length > LongestWord.Length) LongestWord = word;
            return LongestWord;
        }

        public static void GetAllLongestWords(string text)
        {
            StringBuilder sb = new StringBuilder(text.Length);
            string LongestWord = GetLongestWord(text);
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words) if (word.Length == LongestWord.Length) sb.Append(word + " ");
            Console.WriteLine("Строка из самых длинных слов в сообщения (из одного слова, если оно единственное):\n" + sb);
        }

        public static void FrequencyAnalysis(string text, string[] sample_words)
        {
            /*БЕЗ использования RegEx, через словарь (как требует методичка)
            //сравниваем каждое слово предложения с каждым элементом словаря, увеличиваем счетчик, если есть совпадение            
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string sample in sample_words) dict.Add(sample, 0); //формируем словарь из массива слов
            foreach (string sample in sample_words)
                foreach (string word in words) if (sample == word) dict[sample]++;
            foreach (string sample in dict.Keys) Console.WriteLine(sample + " " + dict[sample]);
            */

            //Через Regex коротко :)
            Console.WriteLine("Частотный анализ текста по словарю:");
            foreach (string sample in sample_words)
                Console.WriteLine($"{sample} - {Regex.Matches(text, "\\W*" + sample + "\\W+", RegexOptions.IgnoreCase).Count} раз");
        }
    }
}
