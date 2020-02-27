using System;
using System.Collections.Generic;
/*
Implement function CountNumbers that accepts a sorted array of unique integers and,
efficiently with respect to time used, counts the number of array elements that are less than the parameter lessThan.
For example,
    SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) should return 2
    because there are two array elements less than 4.
*/
public class SortedSearch
{
    public static int CountNumbers_Loop(int[] sortedArray, int lessThan)
    {
        var c = 0;var i = 0;
        while(i<sortedArray.Length && sortedArray[i] < lessThan)
        {
            c++;
            i++;
        }
        return c;
    }

    public static int CountNumbers_Hashset(int[] sortedArray, int lessThan)
    {
        var set = new HashSet<int>(sortedArray);
        var c = set.Count - set.RemoveWhere(e => e >= lessThan);
        return c;
    }

    public static int CountNumbers_BinarySearch(int[] sortedArray, int lessThan)
    {
        if (sortedArray.Length == 0) { return 0; }
        var c = Array.BinarySearch(sortedArray, lessThan);
        if (c < 0)
        {
            return ~c;
        }
        return c;
    }

    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        return CountNumbers_BinarySearch(sortedArray, lessThan);
    }

    public static void Check()
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7,9,15 }, 6));
    }
}
