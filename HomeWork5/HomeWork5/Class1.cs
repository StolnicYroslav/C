﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


///*
// 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст,
//в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary. 
//*/
//namespace HomeWork5
//{
//    internal class Massage
//    {
//        string text = "Посадил дед репку. Выросла репка большая-пребольшая. Стал дед репку из земли тянуть: тянет - потянет, вытянуть не может. Позвал дед на помощь бабку. Бабка за дедку, дедка за репку — тянут - потянут, вытянуть не могут. Позвала бабка внучку. Внучка за бабку, бабка за дедку, дедка за репку — тянут - потянут, вытянуть не могут.";

//            Console.WriteLine("Наше сообщение:\n" + text + "\n");
//            Console.WriteLine("Вывод слов, содаржащих не более 4 букв: ");
//            Message.GetWordsOfLength(text, 4);
//            Console.WriteLine("\n\nУдаляем из сообщения слова, заканчивающиеся на а:");
//             Message.RemoveWords(text, 'а');
//                        Console.WriteLine();

//                        Console.WriteLine("Самое длинное слово в сообщении:\n" + Message.GetLongestWord(text) + "\n");

//                        Message.GetAllLongestWords(text);
//                        Console.WriteLine();

//                        String[] Dictionary = { "дед", "деда", "репка", "реп", "самолет", "тянут", "потянет" };
//        Message.FrequencyAnalysis(text, Dictionary);

//                        Pause();
//    }
//}