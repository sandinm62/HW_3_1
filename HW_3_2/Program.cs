using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_2
{
    //Сандин М.С.
    //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
    //вывести на экран, используя tryParse.
    class Program
    {

        static int Input()
        {
            int number;
            bool res = int.TryParse(Console.ReadLine(), out number);
            if (res)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число");
                return number;
            }

        }

        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите числа.Для завершения ввода введите ноль. ");
            int n = Input();

            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    sum = sum + n;
                    n = Input();
                }
                else
                    n = Input();
            }
            Console.WriteLine("Сумма: " + sum);
            Console.ReadKey();
        }
    }
}
