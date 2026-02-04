using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0)
            return 0;

        int index = 0;
        LinkedListNode<int>? current = myLList.First;

        while (current != null)
        {
            if (index == n)
                return current.Value;

            current = current.Next;
            index++;
        }

        return 0;
    }
}