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
            Console.WriteLine("=============================");
            Console.WriteLine("Example on arraylist ");

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

            //To see if element present or not
            Console.WriteLine("Element present or not : " + arrayList.Contains(56));

            //To see if element present or not
            Console.WriteLine("Element present or not : " + arrayList.Contains(8));


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
            Console.WriteLine("=============================");
            Console.WriteLine("Example on stack ");

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
            Console.WriteLine("=============================");
            Console.WriteLine("Example on queue ");

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

        //List

        public void DisplayList()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Example on list ");

            //To create list
            List<string> itemList = new List<string>();

            //Adding objects to list
            itemList.Add("Exo");
            itemList.Add("Bts");
            itemList.Add("Blackpink");
            itemList.Add("WannaOne");
            itemList.Add("Twice");
            itemList.Add("Super Junior");

            //To iterate the items in list
            foreach (var element in itemList)
            {
                Console.WriteLine("Items are :" + element);
            }

            //To see if element present or not
            Console.WriteLine("Element present or not : " +itemList.Contains("Twice"));

            //To find the capacity
            Console.WriteLine("Capacity of list : " +itemList.Capacity);

            //To find the count
            Console.WriteLine("Count of list : " +itemList.Count);
        }

        //Hashset

        public void DisplayHashSet()
        {

            Console.WriteLine("=============================");
            Console.WriteLine("Example on hash set ");
            HashSet<string> hashList1 = new HashSet<string>();
            //To add items
            hashList1.Add("Teji");
            hashList1.Add("Bhagi");
            hashList1.Add("Adi");
            hashList1.Add("Kai");

            //To display hash set
            foreach (var element in hashList1)
            {
                Console.WriteLine(element);
            }

            //To see if element present or not
            Console.WriteLine("Element present or not : " + hashList1.Contains("Adi"));

            //To see if element present or not
            Console.WriteLine("Element present or not : " + hashList1.Contains("Taemin"));


            //to get count
            Console.WriteLine("Total number of elements present in hash list : {0}", hashList1.Count);

            //Remove a element
            hashList1.Remove("Kai");

            //to get count after removing element
            Console.WriteLine("Total number of elements present in hash list : {0}", hashList1.Count);

            //clearing the hash set
            hashList1.Clear();

            //to get count after clearing the hash set
            Console.WriteLine("Total number of elements present in hash list : {0}", hashList1.Count);

        }

        //Dictionary
        public void DisplayDictionary()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Example on dictionary ");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Teji");
            dictionary.Add(2, "Lee Minho");
            dictionary.Add(3, "Taemin");
            //Using key
            Console.WriteLine("To access using key(key = 2) : " + dictionary[2]);
            //To iterate the items in list
            foreach (var element in dictionary)
            {
                Console.WriteLine("key : " + element.Key + "& value : " + element.Value);
            }

        }
    } 
       
}
