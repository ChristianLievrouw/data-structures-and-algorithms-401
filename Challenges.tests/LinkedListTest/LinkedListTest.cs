using System;
using DataStructures.LinkedLists;
using Challenges.LinkLists;
using Xunit;

namespace Challenges.tests.LinkedListTest
{
    public class LinkedListTest
    {
        [Fact]
        public void LinkedList_zip_two_lists_together()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Append(1);
            list1.Append(3);
            list1.Append(5);

            list2.Append(2);
            list2.Append(4);
            list2.Append(6);

            LinkedList expected = new LinkedList();

            expected.Append(1);
            expected.Append(2);
            expected.Append(3);
            expected.Append(4);
            expected.Append(5);
            expected.Append(6);

            LinkedList result = LinkedListsZip.Zipper(list1, list2);

            Assert.Equal(expected.ToString(), result.ToString());
        }

        [Fact]
        public void LinkedList_zip_two_lists_together_two_dif_size_list()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            
            list1.Append(1);

            list2.Append(2);
            list2.Append(3);
            list2.Append(4);

            LinkedList expected = new LinkedList();

            
            expected.Append(1);
            expected.Append(2);
            expected.Append(3);
            expected.Append(4);

            LinkedList result = LinkedListsZip.Zipper(list1, list2);

            Assert.Equal(expected.ToString(), result.ToString());
        }
    }
}
