using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#3 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение первого начального числа");
            int startValue1;
            startValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение первого конечного числа");
            int stopValue1;
            stopValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение второго начального числа");
            int startValue2;
            startValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение второго конечного числа");
            int stopValue2;
            stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res;
            res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine("Сумма сумм ряда равна " + res);
            Console.ReadKey();
        }
    }
}
