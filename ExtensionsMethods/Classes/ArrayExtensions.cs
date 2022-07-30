using System.Collections.Generic;
 
namespace ExtensionsMethods.Classes
{
    static class ArrayExtensions
    {
        public static int CountItem<T>(this T[] arr, T item) where T : struct
        {
            int count = 0;

            foreach (T elem in arr)
            {
                if (item.Equals(elem))
                {
                    count++;
                }
            }

            return count;
        }

        public static T[] DistinctItem<T>(this T[] arr)
        {
            List<T> list = new List<T>();

            foreach (T elem in arr)
            {
                if (!list.Contains(elem))
                {
                    list.Add(elem);
                }
            }

            return list.ToArray();
        }
    }

}

