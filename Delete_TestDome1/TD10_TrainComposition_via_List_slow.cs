using System;
/*
A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.

For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition of two wagons (13 and 7 from left to right). 
Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.

Implement a TrainComposition that models this problem.
*/
public class TrainComposition_using_List
{

    private System.Collections.Generic.List<int> WagonList = new System.Collections.Generic.List<int>();

    public void AttachWagonFromLeft(int wagonId)
    {
        WagonList.Insert(0, wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        WagonList.Add(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        var item = WagonList[0];
        WagonList.RemoveAt(0);
        return item;
    }

    public int DetachWagonFromRight()
    {
        var l = WagonList.Count - 1;
        var item = WagonList[l];
        WagonList.RemoveAt(l);
        return item;
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