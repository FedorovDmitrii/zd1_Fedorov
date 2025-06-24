using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1_Fedorov
{
    class Cat
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                bool onlyLetters = true;
                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        onlyLetters = false;
                        break;
                    }
                }
                if (onlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - Неверное имя! Имя должно содержать только буквы.");
                }
            }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set 
            {
                if (value > 0 && value < 22)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("Вес должен быть не меньше 0 и не больше 21!");
                }
            }
        }
        public Cat(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name}, весом {Weight:F2} кг: МЯЯЯУ!!!");
        }
    }
}
