using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            Node temp = new Node(val);
            if (First==null)
            {
                First = temp;
                return;
            }
            Node move = First;
            while(move.Next != null) 
            { 
                move=move.Next;           
            }
            move.Next = temp;

        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null) return;
            if (First.Data == key) { First = First.Next; return; }
            Node move = First;
            while (move.Next!=null)
            {
                if(move.Next.Data == key) { move.Next = move.Next.Next;return; }
                move = move.Next;
            }


        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            if (First==null)
            {
                First = other_list.First;
            }
            Node move = First;
            while (move.Next != null)
            {               
                move = move.Next;
            }
            move.Next = other_list.First;

        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next


            if (First == null || First.Next == null) return;
            Node prev = null;
            Node current = First;
            Node nextNode = null;

            while (current != null)
            {
                nextNode = current.Next;
                current.Next = prev;
                prev = current;
                current = nextNode;
            }

            First = prev;


        }
    }
}
