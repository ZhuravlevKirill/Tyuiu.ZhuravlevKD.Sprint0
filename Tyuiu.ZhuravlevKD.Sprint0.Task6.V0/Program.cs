using Tyuiu.ZhuravlevKD.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint0.Task6.V0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            
            System.Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            
            System.Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));
            
            System.Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            System.Console.ReadKey(); 
        }
    }
}