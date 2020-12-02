using System;

namespace CollectionPracticeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of collection!!!!!");
            CollectionDemo collectionDemo = new CollectionDemo();

            //Arraylist
            Console.WriteLine("Program for array list");
            collectionDemo.DisplayArrayList();

            //Stack
            Console.WriteLine("=================================");
            Console.WriteLine("Code for stack");
            collectionDemo.DisplayStack();

            //Queue
            Console.WriteLine("=================================");
            Console.WriteLine("Code for queue");
            collectionDemo.DisplayQueue();


        }
    }
}
