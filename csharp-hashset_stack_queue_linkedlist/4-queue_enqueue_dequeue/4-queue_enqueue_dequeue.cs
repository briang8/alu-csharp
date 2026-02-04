using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            List<string> itemsFrontToBack = new List<string>(aQueue);
            int idx = itemsFrontToBack.IndexOf(search);

            List<string> keep = new List<string>();
            if (idx >= 0)
            {
                for (int i = idx + 1; i < itemsFrontToBack.Count; i++)
                    keep.Add(itemsFrontToBack[i]);
            }
            else
            {
                keep = itemsFrontToBack;
            }

            aQueue.Clear();
            for (int i = 0; i < keep.Count; i++)
                aQueue.Enqueue(keep[i]);
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}