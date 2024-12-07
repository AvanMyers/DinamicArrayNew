using System;
using System.Diagnostics;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "1";
            const string CommandExit = "2";

            int sumNumber = 0;
            int startedArraySize = 0;
            string consolCommand;
            int[] array = new int[startedArraySize];
            int[] tempArray = new int[array.Length + 1];
            bool isOpen = true;

            Console.WriteLine($"ВВедите необходимую команду, любое другое число будет добавленно в массив \n" +
                $"{CommandSum} - Вывести сумму всех введенных чисел\n" +
                $"{CommandExit} - Закрыть программу\n");

            while (isOpen)
            {
                consolCommand = Console.ReadLine();

                switch (consolCommand)
                {
                    case CommandSum:
                        for (int i = 0; i < array.Length; i++)
                            sumNumber += array[i];

                        Console.WriteLine($"Сумма всех введенных чисел {sumNumber}");
                        sumNumber = 0;
                        break;

                    case CommandExit:
                        isOpen = false;
                        break;

                    default:

                        for (int i = 0; i < array.Length; i++)
                            tempArray[i] = array[i];

                        array = tempArray;
                        array[array.Length - 1] = Convert.ToInt32(consolCommand);
                        tempArray = new int[array.Length + 1];

                        Console.WriteLine();
                        break;
                }

                Console.Write(" Числа в массиве ");

                foreach (int number in array)
                    Console.Write(number + " ");

                Console.WriteLine();
            }
        }
    }
}
