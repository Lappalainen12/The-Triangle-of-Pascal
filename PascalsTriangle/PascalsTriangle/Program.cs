using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Приложение треугольник Паскаля (вывод в виде прямоугольного треугольника)*/
            //Сложность - просто

            //Ввод исходных данных пользователем
            Console.WriteLine("Введите размерность для треугольника Паскаля: ");
            
            //Объявление переменной типа int, в которую будет сохранено пользовательское значение
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            
            //Выделение отступов и информирование пользователя
            Console.WriteLine("\n");
            Console.WriteLine("Генерируем...");
            Console.WriteLine("\n");
            
            //Инициализация одномерного массива
            int[] result = new int[UserNumber];

            //Присвоение 0-му элементу массива значение 1
            result[0] = 1;


            /*Цикл for осуществляющий перебор значений
              в данном случае, перебор осуществляется до момента, сохранённой в переменной UserNumber,
              которая в свою очередь задаётся пользователем */

            for (int i = 1; i < UserNumber; i++)
            {

                //Объявление переменной типа int со значением 0
                int CountNumber = 0;

                //Вложенный цикл for, чья итерационная переменная j связанна с итерационной переменной внешнего цикла
                for (int j = 0; j <= i; j++)
                {
                    //Объявление переменной типа int с
                    int CountTwoNumber = result[j];

                    //Инкрементирование переменной CountNumber
                    result[j] += CountNumber;

                    //Присвоение переменной CountNumber значение CountTwoNumber
                    CountNumber = CountTwoNumber;

                    //Вывод на консоль CountNumber
                    Console.Write(CountNumber + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Выделение отступов и информирование пользователя
            Console.WriteLine("\n");
            Console.WriteLine("Готово!...");
            Console.WriteLine("\n");

        }
    }
}
