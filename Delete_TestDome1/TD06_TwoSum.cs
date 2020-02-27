using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < list.Count; i++)
        {
            var needed = sum - list[i];
            if (hs.Contains(needed))
            {
                return Tuple.Create(list.IndexOf(needed), i);
            }
            hs.Add(list[i]);
        }
        return null;
    }

    public static void Check(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}