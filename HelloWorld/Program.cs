// Импорт сторонних пространств имен
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Пространство имен
/// Создание совственной бибилиотеки
/// </summary>
namespace HelloWorld
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Код который выполняется в превую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            Console.WriteLine("Привет, мир!"); // Вывод текста 
                                               // в консоль
            Console.Write("Задание 2:");
            Console.Write("Привет, ");
            Console.Write("мир ");
            Console.Write("!!!");

            Console.ReadKey();                 // Ожидание от пользвателя
                                               // Нажатия какой-либо кнопки
        }
    }
}
