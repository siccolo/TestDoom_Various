using System;
using System.Collections.Generic;
using System.Linq;

namespace Delete_TestDome1
{
    public class RecyclingBin
    {
        protected List<string> recyclables = new List<string>();

        public void Add(string recyclable)
        {
            if (recyclable.Split(' ').Length > 1)
            {
                recyclables.Add(recyclable);
            }
        }

        public List<IGrouping<string, string>> SortRecyclables()
        {
            return recyclables.GroupBy(recyclable => recyclable.Split(' ').First()).ToList();
        }
    }
}
