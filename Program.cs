using System;
namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 лаба
            int number = int.Parse(Console.ReadLine());
            
            int firstItem,
                secondItem,
                thirdItem;
            
            firstItem = number / 100;
            secondItem = (number / 10) % 10;
            thirdItem = number % 10;
            
            if (firstItem < secondItem && secondItem < thirdItem)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }*/

            // //2 лаба
            // int size = int.Parse(Console.ReadLine());
            // int value = int.Parse(Console.ReadLine());
            //
            // int[] array = new int[size];
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     Random random = new Random();
            //     array[i] = random.Next(-50, 51);
            //     Console.Write(array[i] + " ");
            // }
            //
            // Console.WriteLine();
            // int nearNumberSum = Int32.MaxValue;
            // int indexOne = 0;
            // int indexTwo = 0;
            //
            // int sum;
            // for (int i = 0; i < array.Length; i++)
            // {
            //     for (int j = 1; j < array.Length; j++)
            //     {
            //         sum = array[i] + array[j];
            //         if (sum - value < nearNumberSum)
            //         {
            //             nearNumberSum = sum - value;
            //             indexOne = i;
            //             indexTwo = j;
            //         }
            //     }
            // }
            // Console.WriteLine($"Sum: {array[indexOne]} + {array[indexTwo]}");
            //
            // for (int i = 0; i < array.Length; i++)
            // {
            //     for (int j = 1; j < array.Length; j++)
            //     {
            //         sum = array[i] - array[j];
            //         if (sum + value > nearNumberSum)
            //         {
            //             nearNumberSum = sum + value;
            //             indexOne = i;
            //             indexTwo = j;
            //         }
            //     }
            // }
            // Console.WriteLine($"Sub: {array[indexOne]} - {array[indexTwo]}");
            
            
            //  3 лаба
            // Console.WriteLine("Row:");
            // int row = int.Parse(Console.ReadLine());
            // Console.WriteLine("Col:");
            // int col = int.Parse(Console.ReadLine());
            //
            // int[,] array = new int[row, col];
            //
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {
            //         array[i, j] = int.Parse(Console.ReadLine());
            //     }
            // }
            //
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {
            //         Console.Write($"{array[i,j]} | ");
            //     }
            //     Console.WriteLine();
            // }
            //
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col - 1; j++)
            //     {
            //         if (array[i, j] >= array[i, j + 1])
            //             break;
            //         if (j == col - 2)
            //             Console.WriteLine($"max:{array[i, j + 1]}");
            //     }
            // }

            
            //4 лаба
            // List<int> list = new List<int>();
            //
            // list.Add(2);
            // list.Add(1);
            // list.Add(2);
            // list.Add(1);
            // list.Add(2);
            // list.Add(1);
            //
            // foreach (var i in list)
            // {
            //     Console.Write(i + " ");
            // }
            //
            // list.RemoveAt(0);
            // Console.WriteLine();
            // foreach (var i in list)
            // {
            //     Console.Write(i + " ");
            // }
            //
            // int countOne = 0,
            //     countTwo = 0;
            //
            // foreach (var item in list)
            // {
            //     if (item == 1)
            //         countOne++;
            //     else
            //         countTwo++;
            // }
            //
            // Console.WriteLine();
            // Console.WriteLine($"CountOne: {countOne}");
            // Console.WriteLine($"CountTwo: {countTwo}");
        }
    }
}