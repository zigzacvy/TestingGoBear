using System.Collections;

namespace ConsoleApp3
{
    public interface ICaculator
    {
        Hashtable Creation();
        Hashtable AddtionData(Hashtable storedData, char[] dataKeys, int value);
        int TotalPoints(Hashtable storedData, string input);
    }
}