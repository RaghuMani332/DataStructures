using System;



namespace DataStructures
{
    class Node
    {
        public Node Next=null;
        public Object obj=null;
        public Node Previous=null;

       public Node(Object obj)
        {
            this.obj = obj;
        }
    }
    class LinkedListImpl
    {

        private Node head;
        private Node tail;

        
        public void Add(Object obj)
        {
            Node newNode = new Node(obj);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
        }
        public void printAll()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.obj);
                current = current.Next;
            }

        }
        public Object get(int index)
        {

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException( "Index must be non-negative");
            }

            Node current = head;
            int currentIndex = 0;
            while (current != null && currentIndex < index)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException( "Index is out of range");
            }

            return current.obj;
        }
        public void deleteByIndex(int index)
        {
            int start = 0;
            Node bottom = permanent;

            while (start < index-1 && bottom.tail != null)
            {
                bottom = bottom.tail;
                start++;

            }
            Node todelete = bottom.tail;
            bottom.tail = todelete.tail;
            todelete.tail.head = bottom;
            
        }
        public void AddByIndex(int index,Object obj)
        {
            int start = 0;
            Node temp = permanent;
            Node newNode = new Node();
            newNode.obj = obj;
            if (index == 0)
            {
                temp.head = newNode;
                newNode.tail = temp;
                return;
            }

            while(temp.tail!=null && start<index-1)
            {
                temp = temp.tail;
                start++;
            }
            
          
            Node tempp = temp.tail;
            temp.tail = newNode;
            newNode.head = temp;
            newNode.tail = tempp;
        }
    }
}
