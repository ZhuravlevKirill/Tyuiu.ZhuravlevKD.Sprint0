using Tyuiu.ZhuravlevKD.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint0.Task7.V0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Title = "Спринт #0 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* Спринт #0                                                               *");
            System.Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            System.Console.WriteLine("* Задание #7                                                              *");
            System.Console.WriteLine("* Вариант #0                                                              *");
            System.Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* УСЛОВИЕ:                                                                *");
            System.Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            System.Console.WriteLine("* одиныковых массивов по длинне.                                          *");
            System.Console.WriteLine("*                                                                         *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            System.Console.WriteLine("***************************************************************************");
            
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            System.Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                System.Console.Write(arrayNums1[i] + ", ");
            }

            System.Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            System.Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                System.Console.Write(arrayNums2[i] + ", ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            System.Console.WriteLine("***************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                System.Console.WriteLine("Сумма элементов массива ровна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    System.Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                System.Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            System.Console.ReadKey();
        }
    }
}