using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class LinkList2
    {
        private Node start;
        private Node last;

        public void linklist2()
        {
            start = null;
            last = null;
        }
        public void AddLast(int isi)
        {
            Node newnode = new Node();
            newnode.isi = isi;

            if (start == null)
            {
                newnode.next = start;
                start = newnode;
                last = newnode;
            }
            else
            {
                last.next = newnode;
                last = newnode;
            }
        }
        public void display()
        {
            Node currentNode;
            for (currentNode = start; currentNode != null; currentNode = currentNode.next)
            {
                Console.WriteLine(currentNode.isi);
            }
        }
    }
}
