using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint3.Task7.V14.Lib;


namespace Tyuiu.GrigorjanAM.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Григорян А. М. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, выводящую таблицу значений функции,                 *");
            Console.WriteLine("* на диапазоне [-5,5] с шагом 1. Проверить деление на ноль => вернуть ноль*");
            Console.WriteLine("* где функция - F(x) = 2x - 4  + (2x-1) / (sin(x) + 1)                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startvalue = -5;
            int stopvalue = 5;
            Console.WriteLine("Старт шага = " + startvalue);
            Console.WriteLine("Конец шага = " + stopvalue);

            int len = ds.GetMassFunction(startvalue, stopvalue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startvalue, stopvalue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("[{0}]", string.Join(", ", valueArray));

            Console.ReadKey();


        }
    }
}
