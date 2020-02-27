using System;
using System.Linq;

namespace Delete_TestDome1
{
    public static class TD2
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var allnames = names1.Concat(names2);
            return allnames.Distinct().ToArray();
        }
    }
}
