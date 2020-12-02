using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionPracticeDemo
{
    public class CollectionDemo

    {

        //Arraylist
        public void DisplayArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(42);
            arrayList.Add(56);
            arrayList.Add(60);
            arrayList.Add(6);
            arrayList.Add(99);

            Console.WriteLine("Capacity : {0} ", arrayList.Capacity);
            Console.WriteLine("Count : {0} ", arrayList.Count);

            Console.WriteLine("Content : ");
            foreach (int i in arrayList)
            {
                Console.WriteLine(i + " ");
            }
                
            Console.WriteLine("Content in sorted order : ");
            arrayList.Sort();
            foreach(int i in arrayList)
            {
                Console.WriteLine( i + " ");
            }

        }

        //Stack
        public void DisplayStack()
        {
            Stack stackList = new Stack();

            stackList.Push("Amanda");
            stackList.Push("Malfoy");
            stackList.Push("Griffindor");
            stackList.Push("Weasley");

            Console.WriteLine("Current stack: ");
            foreach (var element in stackList)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            stackList.Push("Veronica");
            stackList.Push("Hogwarts");
            Console.WriteLine("The next poppable value in stack: {0}", stackList.Peek());
            Console.WriteLine("Current stack: ");

            foreach (var element in stackList)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            stackList.Pop();
            stackList.Pop();
            stackList.Pop();

            Console.WriteLine("Current stack: ");
            foreach (var element in stackList)
            {
                Console.Write(element + " ");
            }

            stackList.Clear();
            Console.WriteLine("\nElements present in stack after clearing all  elements : " + stackList.Count);
        }

        //Queue
        public void DisplayQueue()
        {
            Queue queueList = new Queue();

            queueList.Enqueue("Alfredo");
            queueList.Enqueue("Mango");
            queueList.Enqueue("Grapes");
            queueList.Enqueue("Watermelon");

            Console.WriteLine("Current queue: ");
            foreach (var element in queueList) 
                Console.Write(element + " ");

            
            queueList.Enqueue("Orange");
            queueList.Enqueue("Hazelnut");
            Console.WriteLine("Current queue: ");
            foreach (var element in queueList) 
                Console.Write(element + " ");

           
            Console.WriteLine("Total number of elements present in queue is::" + queueList.Count);
           
            Console.WriteLine("Removing top most element : " + queueList.Dequeue());
            Console.WriteLine("Total number of elements after removing one element::" + queueList.Count);
           
            Console.WriteLine("Top most element in queue:" + queueList.Peek());
            
            Console.WriteLine("Checking element is present or not:" + queueList.Contains("Mango"));
           
            queueList.Clear();
            Console.WriteLine("Total number of elements left:" + queueList.Count);
        }
    }
 
       
}
