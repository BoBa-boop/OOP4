using System;

namespace ConsoleApp7
{
    class Health
    {
        private int Temp;
        public int Temperature
        {
            get
            {
                return Temp;
            }
            set
            {
                if (value < 34 || value > 41)
                    Console.WriteLine("Вы вышли за диапозон ");
                else
                    Console.WriteLine("Ваша температура составляет " + value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру от 34 до 41 ");
            int NumTemp = Convert.ToInt32(Console.ReadLine());
            Health newTem = new Health();
            newTem.Temperature = NumTemp;
            
            Console.ReadKey();
        }
    }
}
