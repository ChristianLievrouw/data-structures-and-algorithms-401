using System;
using DataStructures;
using DataStructures.LinkedLists;
namespace Challenges.LinkLists
{
    public class LinkedListsZip
    {
       public static LinkedList Zipper(LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            LinkedList result = new LinkedList();

            while(current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    result.Append(current1.Value);
                    current1 = current1.Next;
                }
                if (current2 != null)
                {
                    result.Append(current2.Value);
                    current2 = current2.Next;
                } 
            }
            return result;
        }
    }

}