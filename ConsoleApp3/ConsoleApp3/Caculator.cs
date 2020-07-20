using System;
using System.Collections;
using System.Linq;

namespace ConsoleApp3
{
    public class Caculator : ICaculator
    {
        public Hashtable Creation()
        {
            char[] onePoints = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
            char[] twoPoints = {'D', 'G'};
            char[] threePoints = {'B', 'C', 'M', 'P'};
            char[] fourPoints = {'F', 'H', 'V', 'W', 'Y'};
            char[] fivePoints = {'K'};
            char[] eightPoints = {'J', 'X'};
            char[] tenPoints = {'Q', 'Z'};

            var storedData = new Hashtable();
            storedData = AddtionData(storedData, onePoints, 1);
            storedData = AddtionData(storedData, twoPoints, 2);
            storedData = AddtionData(storedData, threePoints, 3);
            storedData = AddtionData(storedData, fourPoints, 4);
            storedData = AddtionData(storedData, fivePoints, 5);
            storedData = AddtionData(storedData, eightPoints, 8);
            storedData = AddtionData(storedData, tenPoints, 10);
            return storedData;
        }

        public Hashtable AddtionData(Hashtable storedData, char[] dataKeys, int value)
        {
            if (dataKeys == null) throw new ArgumentNullException(nameof(dataKeys));
            foreach (var key in dataKeys) storedData.Add(key, value);

            return storedData;
        }

        public int TotalPoints(Hashtable storedData, string input)
        {
            if (storedData == null) throw new ArgumentNullException(nameof(storedData));
            if (input == null) throw new ArgumentNullException(nameof(input));

            return (from c in input
                from DictionaryEntry item
                    in storedData
                where c == (char) item.Key
                select (int) item.Value).Sum();
        }
    }
}