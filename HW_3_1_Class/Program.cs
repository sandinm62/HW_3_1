using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_1_Class
{
    //Сандин М.С.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    class Complex
    {

        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;

        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;

        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.re * im + x2.im * re;
            x3.re = x2.re * re - x2.im * im;


            return x3;


        }
        public Complex Defference(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public string ToString()
        {
            if (im < 0)
            {
                return re + "" + im + "i";
            }
            return re + "+" + im + "i";
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            Complex complex1 = new Complex(1, 1);
            Complex complex2 = new Complex(2, 2);

            complex2.Im = 3;

            Complex result;
            Console.WriteLine("Введите номер действия результат которого хотите получить" +
                "\n 1. Сложение" +
                "\n 2. Произведение" +
                "\n 3. Разность");

            int number = Convert.ToInt32(Console.ReadLine());


            switch (number)
            {
                case 1:
                    result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    break;

                case 2:
                    result = complex1.Multi(complex2);
                    Console.WriteLine(result.ToString());
                    break;

                case 3:
                    result = complex1.Defference(complex2);
                    Console.WriteLine(result.ToString());
                    break;

                default:
                    Console.WriteLine("Вы ввели неверное число");
                    break;

            }


            Console.ReadKey();

        }
    }
}
