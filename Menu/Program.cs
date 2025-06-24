using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Выберите проект ===");
                Console.WriteLine("1. Запустить Кота (Консоль)");
                Console.WriteLine("2. Запустить Магазин (Windows Forms)");
                Console.WriteLine("3. Запустить Плейлист (Windows Forms)");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        zd1_Fedorov.Program.Main(null);
                        break;
                    case "2":
                        zd2_Fedorov.Program.Main();
                        break;
                    case "3":
                        zd3_Fedorov.Program.Main();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}
