using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Fedorov
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя кота:");
            string inputName = Console.ReadLine();
            Console.WriteLine("Введите вес кота:");
            string inputWeightSting = Console.ReadLine();
            double inputWeight = 3.5;
            bool isDouble = double.TryParse(inputWeightSting, out inputWeight);
            if (!isDouble || inputWeight <= 0)
            {
                Console.WriteLine("Некоректный ввод веса. Установленно значение по умолчанию: 3.5");
                inputWeight = 3.5;
            }
            bool nameIsValid = true;
            foreach (char c in inputName)
            {
                if (!char.IsLetter(c))
                {
                    nameIsValid = false;
                    break;
                }
            }
            if (!nameIsValid)
            {
                Console.WriteLine("Кот не создан из-за некорректного имени.");
            }
            else
            {
                Cat myCat = new Cat(inputName, inputWeight);
                myCat.Meow();
            }
        }
    }
}
