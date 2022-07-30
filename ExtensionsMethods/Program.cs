using ExtensionsMethods.Classes;
using ExtensionsMethods.Classes.Generalized_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // підрахунок кількості входжень заданого у параметрі символа у рядок.
            Console.Write("Введіть речення, підрахунок в якму бажаєте здійснити:");

            string str = Console.ReadLine();
            int v = str.WordCount('!');

            Console.WriteLine($"Кількість входжень: {v} \n");

            //інвертування рядка
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("a one string");
            listOfStrings.Add("a two string");
            listOfStrings.Add("a three string");
            listOfStrings.Add("a four string");
            listOfStrings.Add("a five string");

            string result = listOfStrings.ListToString();

            Console.WriteLine($"Результат виконання інвертування: \n {result} \n ");

            // визначення кількості разів зустрічання даного значення у масиві
            int[] arr = {1,1,2,2,2,3,4,4,4,4,4,5};
            int resArr = arr.CountItem(4);
            
            Console.WriteLine($"Масив пошук в якому будимо здійснювати:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");

            }

            Console.WriteLine($"\nКількість значень в даному масиві: {resArr} \n");

            // повертає новий масив такого ж типу і формує його з унікальних елементів
            int[] res = arr.DistinctItem();

            Console.WriteLine($"Новий масив такого ж типу сформований з унікальних елементів:");

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write($"{res[i]} ");

            }
            Console.WriteLine();

            // додавання елемента у словник;
            ExtendedDictionary<int, string, string> extendedDictionary = new ExtendedDictionary<int, string, string>();
            extendedDictionary.Add(0, "0", "0");
            extendedDictionary.Add(1, "A1", "a1");
            extendedDictionary.Add(2, "B2", "b2");
            extendedDictionary.Add(3, "C3", "c3");
            extendedDictionary.Add(4, "D4", "d4");

            Console.WriteLine("Додавання елемента у словник");

            extendedDictionary.ShowDictonary();

            //видалення елемента з словника за заданим ключем;
            Console.WriteLine("Видалення елемента");
            extendedDictionary.Remove(0);
            extendedDictionary.ShowDictonary();

            // перевірка наявності елемента із заданим ключем;
            Console.WriteLine("Перевірка наявності елемента із заданим ключем");
            extendedDictionary.GetForKey1(3);

            // перевірка наявності елемента із заданим значенням (значення1 та значення2);
            Console.WriteLine("Перевірка наявності елемента із заданим значенням");
            Console.WriteLine(extendedDictionary.GetForTwoValues("A1", "a1"));

            // повернення елемента за заданим ключем (реалізувати операцію індексування); 
            Console.WriteLine("повернення елемента за заданим ключем (реалізувати операцію індексування)");
            extendedDictionary.GetForKey(3);
            
            // властивість, що повертає кількість елементів
            Console.WriteLine("Кількість елементів");
            extendedDictionary.TheNumberOfElements();
            Console.ReadLine();
        }
    }

}
