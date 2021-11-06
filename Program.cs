using System;
namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //на майбутнє, пиши текст завдання в коментарях перед лабораторною
            /*1 лаба
            int number = int.Parse(Console.ReadLine()); //коли просимо користувача ввести щось з екрану, ми повинні пояснити йому що ми хочемо
            
            int firstItem,
                secondItem,
                thirdItem;
            
            firstItem = number / 100;
            secondItem = (number / 10) % 10;
            thirdItem = number % 10;
            
            if (firstItem < secondItem && secondItem < thirdItem)
            {
                Console.WriteLine(true); //під час виводу ми також маємо думати про користувача, просте true/false не дасть користувачу повної картини про роботу програми
            }
            else
            {
                Console.WriteLine(false);
            }*/
            
            //Дано дійсне число R і масив розміру N. Знайти два елементи масиву, сума яких найближча і найдальша від даного числа. 
            // //2 лаба
            // int size = int.Parse(Console.ReadLine()); //те саме зауваження що й до 1 лаби
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
            // for (int i = 0; i < array.Length; i++) //в такій реалізації буде неправильно знайдено максимальну суму елементів оскільки в розрахунок буде включено  array[i]*2
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
            // Console.WriteLine($"Sum: {array[indexOne]} + {array[indexTwo]}"); //Знайти потрібно було не суму а елементи(індекси цих елементів)
            // 
            // for (int i = 0; i < array.Length; i++) // в такій реалізації буде неправильно знайдено максимальну суму елементів оскільки в розрахунок буде включено  array[i]*2
            // {
            //     for (int j = 1; j < array.Length; j++)
            //     {
            //         sum = array[i] - array[j]; //чому сума стала різницею? 
            //         if (sum + value > nearNumberSum)
            //         {
            //             nearNumberSum = sum + value;
            //             indexOne = i;
            //             indexTwo = j;
            //         }
            //     }
            // }
            // Console.WriteLine($"Sub: {array[indexOne]} - {array[indexTwo]}"); //Знайти потрібно було не суму а елементи(індекси цих елементів)
            
            //Дана матриця розміру m *  n. Знайти  максимальний серед елементів тих рядків матриці, які впорядковані або за зростанням. Якщо такі рядки відсутні, то вивести 0. 
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
            //         array[i, j] = int.Parse(Console.ReadLine()); //треба було генерувати рандомом, якщо ввести розмір матриці 100х100 втомишся заповнювати її 
            // //і знову ж таки не зрозуміло що ти хочеш від користувача
            //     }
            // }
            //
            // for (int i = 0; i < row; i++)
            // {
            //     for (int j = 0; j < col; j++)
            //     {
            //         Console.Write($"{array[i,j]} | "); //поганий спосіб виводити матрицю, бажано використовувати табуляцію що б не було зубчастих масивів
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
            //             Console.WriteLine($"max:{array[i, j + 1]}"); // ти вивиодиш максимальний елемент кожного рядочку впорядкованих за сростанням, а потрібно вивести
            // //макисамльний серед таких елементів
            //     }
            // } // а де вивід нуля, якщо в нас немає рядочків впорядкованих за сростанням? 

            // Створити ліст інтових значень, який може вміщати тільки 2 та 1, вивести серії повторень, для кожного чисел. Видалити елементи з простими індексами.
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
            // list.RemoveAt(0); //чому було видалено 0 елемент? 
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
            // Console.WriteLine($"CountOne: {countOne}"); // порахувати потрібно було серії повторень а не кількість елементів( серія повторень це наприклад 1,1,1)
            // Console.WriteLine($"CountTwo: {countTwo}");
        }
    }
}
