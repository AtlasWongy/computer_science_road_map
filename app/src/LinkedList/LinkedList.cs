using System;

namespace app.LinkedList
{
    internal class LinkedList {
       public Node head;
    
       public LinkedList(Node head)
       {
            this.head = head;
       }
    
       public void AddNode(int data) 
       { 
            Node newNode = new Node(data);
            Node currentNode = head;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = newNode;
       }
    
       public void DeleteNode(int data)
       {
            if (this.head.data.Equals(data))
            {
                head = head.next;
                return;
            }
    
            Node currentNode = head;
            Node previousNode = null;
    
            while (currentNode != null)
            {
                if (currentNode.data.Equals(data))
                {
                    previousNode.next = currentNode.next;
                    return;
                }
    
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
       }
    
       public int CountNodes(Node head)
       {
            int count = 1;
            Node current = head;
    
            while (current.next != null)
            {
                count++;
                current = current.next;
            }
            return count;
       }
    
       public void PrintNodes()
       {
            Node currentNode = head;
            while(currentNode != null)
            {
                Console.Write(currentNode.data + " -> ");
                currentNode = currentNode.next;
            }
            Console.WriteLine("null");
       }
    }
}
