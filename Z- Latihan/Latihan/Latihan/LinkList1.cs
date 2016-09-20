using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Latihan
{
    class LinkList1
    {
        private Node start;

        public LinkList1()
        {
            start = null;
        }
        public void AddFirst(int isi)
        {
            Node newnode = new Node();
            newnode.isi = isi;

            newnode.next = start;
            start = newnode;
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
