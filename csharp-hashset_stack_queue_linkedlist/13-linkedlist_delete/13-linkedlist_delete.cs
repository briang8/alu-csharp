using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || myLList.First == null)
            return;

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        while (current != null && currentIndex < index)
        {
            current = current.Next;
            currentIndex++;
        }

        if (current != null)
        {
            myLList.Remove(current);
        }
    }
}