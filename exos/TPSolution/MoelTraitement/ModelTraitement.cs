using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Traitement
    {
        public static string[] TraitementText(String str)
        {
            string[] strTransform = str.ToUpper().Split(' ');
            Reverse(strTransform);
            return strTransform;
        }

        static void Reverse<T>(T[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n / 2; i++)
            {
                T temp = tab[i];
                tab[i] = tab[n - 1 - i];
                tab[n - 1 - i] = temp;
            }
        }
    }
}
