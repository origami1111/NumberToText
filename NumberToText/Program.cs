using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите целое число которое нужно преобразовать в прописной вариант: ");
            Console.Write(" > ");
            number = Convert.ToInt32(Console.ReadLine());

            NumberToText numberInText = new NumberToText(number);
            numberInText.convertNumber();

            Console.WriteLine("Программа завершена");
            Console.ReadLine();
        }
    }
}
