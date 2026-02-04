using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack == null)
            aStack = new Stack<string>();

        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            List<string> itemsTopToBottom = new List<string>(aStack);
            int idx = itemsTopToBottom.IndexOf(search);

            List<string> keep = new List<string>();
            if (idx >= 0)
            {
                for (int i = idx + 1; i < itemsTopToBottom.Count; i++)
                    keep.Add(itemsTopToBottom[i]);
            }
            else
            {
                keep = itemsTopToBottom;
            }

            aStack.Clear();
            for (int i = keep.Count - 1; i >= 0; i--)
                aStack.Push(keep[i]);
        }

        aStack.Push(newItem);

        return aStack;
    }
}