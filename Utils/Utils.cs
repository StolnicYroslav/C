using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Utils
    {
        /// <summary>
        /// Метод для остановки программы и ожидания нажатия пользователем любой клавиши
        /// </summary>
        public void Pause()
        {
            Console.Write("\nНажмите любую клавишу чтобы продолжить");
            Console.ReadKey();
        
        }
    }

}
