using System;
using System.Collections;
using DataStructures;
using DataStructures.Stack;

namespace Challenges
{
    public class AnimalShelter<T>
    {
        public class Animal
        {
            public enum Type
            {
                Dog,
                Cat,
                Bird
            }
        }

        Queue<Animal.Type> queue = new Queue<Animal.Type>();

        public void Enqueue(Animal.Type animal)
        {
            queue.Enqueue(animal);
        }

        public Animal.Type Dequeue(Animal.Type pref)
        {
            //var current = queue.Front;

            //while(current.Next != null)
            //{ 
            //if(current.Value == pref)
            //    {
            //        return queue.Dequeue();
            //    }
            //    current = current.Next;
            //}
            //return default;
            if (pref == Animal.Type.Cat || pref == Animal.Type.Dog)
            {
                return queue.Dequeue();
            }
            else
            {
                return default;
            }
        }

        public Animal.Type Peek()
        {
            return queue.QPeek();
        }

        public bool QIsEmpty()
        {
            if (queue.QIsEmpty())
                return true;
            else
                return false;
        }

    }

}
