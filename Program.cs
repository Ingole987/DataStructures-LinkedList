// See https://aka.ms/new-console-template for more information
using System;

namespace DataStructureAndLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(40);
            linkedlist.Add(70);
            linkedlist.Display();
            Console.WriteLine("--------------");

            SortLinkedList Sortlinkedlist = new SortLinkedList();
            Sortlinkedlist.Add(56);
            Sortlinkedlist.Add(30);
            Sortlinkedlist.Add(40);
            Sortlinkedlist.Add(70);
            Sortlinkedlist.Display();
            Console.WriteLine("--------------");

            //linkedlist.RemoveFirstNode();
            //linkedlist.RemoveLastNode();
            //linkedlist.search(30);
            //linkedlist.InsertAtParticularPosition(3, 40);
            //linkedlist.Delete(40);
            //linkedlist.Display();
            //Console.ReadKey();
        }
    }
}