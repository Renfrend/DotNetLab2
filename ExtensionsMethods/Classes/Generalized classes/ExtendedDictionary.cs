using System;
using System.Collections.Generic;

namespace ExtensionsMethods.Classes.Generalized_classes
{
    class ExtendedDictionary<T, U, V>
    {
        public T Key { get; set; }

        public U GetFisrtValue { get; set; }

        public V GetSecondValue { get; set; }

        public List<string> list = new List<string>();

        // додавання елемента у словник;
        public void Add(T Key, U GetFisrtValue, V GetSecondValue)
        {
            list.Add($"{Key} - {GetFisrtValue} - {GetSecondValue}");
        }
        
        // видалення елемента з словника за заданим ключем;
        public void Remove(int Key)
        {
            list.Remove(list[Key]);
        }
        // перевірка наявності елемента із заданим ключем;
        public void GetForKey1(int Key)
        {
            if (Key != null)
                Console.WriteLine("Елемент заданим ключем існує");
            else
                Console.WriteLine("Помилка!");
        }

        // перевірка наявності елемента із заданим значенням (значення1 та значення2);
        public string GetForTwoValues(U GetFisrtValue, V GetSecondValue)
        {
            foreach (string element in list)
            {
                if (GetFisrtValue != null && GetSecondValue != null)
                {
                    return "Дані елементи існують";
                }
            }
            return "Даних значень не існує!!!";
        }

        // повернення елемента за заданим ключем (реалізувати операцію індексування); 
        public void GetForKey(int Key)
        {
            if (Key != null)
                Console.WriteLine(list[Key]);
            else
                Console.WriteLine("Помилка!");
        }

        // властивість, що повертає кількість елементів
        public void TheNumberOfElements()
        {
            int sum = 0;
            foreach (string l in list)
            {
                ++sum;
            }
            Console.WriteLine(sum);
        }
        // вивидення вмісту словника
        public void ShowDictonary() 
        {
            foreach (string l in list)
            {
                Console.WriteLine(l);
            }
        }

    }
}
