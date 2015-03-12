using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLinkedList = new LinkedList();
            myLinkedList.Add(1);
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(4);
            
            Console.Write(myLinkedList.ToString());
            Console.WriteLine("\n" + "Reverse:");
            myLinkedList.Reverse();
            Console.Write(myLinkedList.ToString());
            Console.ReadLine();
        }

        

    }
}
