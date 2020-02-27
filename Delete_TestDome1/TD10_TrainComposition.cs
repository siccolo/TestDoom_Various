using System;

public class TrainComposition
{
    private System.Collections.Generic.LinkedList<int> WagonList = new System.Collections.Generic.LinkedList<int>();

    public void AttachWagonFromLeft(int wagonId)
    {
        WagonList.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        WagonList.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        if (WagonList.Count > 0) {
            int wagon = WagonList.First.Value;
            WagonList.RemoveFirst();
            return wagon; 
        }
        return -99;
    }

    public int DetachWagonFromRight()
    {
        if (WagonList.Count > 0)
        {
            int wagon = WagonList.Last.Value;
            WagonList.RemoveLast();
            return wagon;
        }
        return -99;
    }
    public static void Check()
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}