using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLibrary
{    
    public static class Extensions
    {
        private static Random randomGenerator = new Random();

        public static List<T> Shuffle<T>(List<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int k = randomGenerator.Next(i + 1);
                T item = list[k];
                list[k] = list[i];
                list[i] = item;
            }
            return list;
           
        }
    }
}
