using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{
    //TODO: come back and understand it Fisher Yates Shuffle 
    public static class Extensions
    {
        private static Random randomGenerator = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int k = randomGenerator.Next(i + 1);
                T item = list[k];
                list[k] = list[i];
                list[i] = item;
            }
        }
    }
}
