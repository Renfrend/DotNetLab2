using System.Collections;
using System.Text;

namespace ExtensionsMethods.Classes
{
    public static class String
    {
        public static int WordCount(this string str, char a)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == a)
                    counter++;
            }
            return counter;
        }
        // інвертування рядка
        public static string ListToString(this IList list)
        {
            StringBuilder result = new StringBuilder("");
            if (list.Count > 0)
            {
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                    result.AppendFormat(", {0}",
                       list[i].ToString());
            }
            return result.ToString();
        }
    }
}
