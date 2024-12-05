using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YazProgLab2
{
    internal class LinkedList
    {
        Node node;
        int size = 0;
        public void addFirst(string data)
        {
            Node p = new Node(data);
            p.next = node;
            node = p;
            size++;
        }
        public void addLast(string data)
        {
                Node p = node;
            if (p == null)
            {
                node = new Node(data);
            }else
            {
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = new Node(data);
            }
            size++;
          //  node = p;
        }
        public void addToPos(string data, int index)
        {
            Node p = node;
            int f_index = 0;
            if (index==0)
            {
                addFirst(data);
            }
            else
            {
                while (f_index != index - 1)
                {
                    if (p == null) throw new IndexOutOfRangeException(index + "");
                    p = p.next;
                    f_index++;
                }
                Node ins = new Node(data);
                ins.next = p.next;
                p.next = ins;
                size++;
                 
            }
        }
        public void removeFirst()
        {
            if (node != null)
            {
                node = node.next;
                size--;
            }
        }
        public void removeLast()
        {
            if (node == null)
            {
                return;
            }
            if (node.next == null)
            {
                node = null;
            }
            else
            {
                Node p = node;
                while (p.next.next != null)
                {
                    p = p.next;
                }
                p.next = null;
            }
            size--;
        }
        public void removeToPos(int pos)
        {
            if(node == null)return;
            if (pos == 0)
            {
                removeFirst();
                return;
            }
          
            Node p = node;
            int myPos = 0;
            while (myPos != pos-1)
            {
                
                p = p.next;
                myPos++;
            }
            if (pos>size) throw new IndexOutOfRangeException(pos.ToString());
            if (p.next != null)
            {
                p.next = p.next.next;
            }
            else
                p.next = null;
            size--;
        }
        public static LinkedList merge(LinkedList list1,LinkedList list2)
        {
            if (list1.node == null) return list2;
            if (list2.node == null) return list1;

            Node p1 = list1.node; 
            Node p2 = list2.node; 
            Node resultNode = null; 
            Node current = null;            
            while (p1 != null || p2 != null)
            {
                if (p1 != null)
                {
                    if (resultNode == null)
                    {
                        resultNode = p1; 
                        current = resultNode;
                    }
                    else
                    {
                        current.next = p1; 
                        current = current.next; 
                    }
                    p1 = p1.next; 
                }
                if (p2 != null)
                {
                    if (resultNode == null)
                    {
                        resultNode = p2;
                        current = resultNode;
                    }
                    else
                    {
                        current.next = p2; 
                        current = current.next; 
                    }
                    p2 = p2.next; 
                }
            }
            LinkedList result = new LinkedList();
            result.node = resultNode;
            result.size = list1.size + list2.size;
            return result;
        }
        public string get(int pos)
        {
            Node p = node;
            int now_pos = 0;
            while(pos!=now_pos)
            {
                if (p == null) throw new IndexOutOfRangeException(now_pos + "");
                p = p.next;
                now_pos++;
            }
            return p.data;
        }
        public int getSize()
        {
            return size;
        }
        class Node
        {
            public Node next;
            public string data;
            public Node(string data) { this.data = data; }
        }
    }
}
