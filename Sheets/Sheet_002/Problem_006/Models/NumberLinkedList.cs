using System;
using System.Diagnostics.Metrics;

namespace Problem_006.Models;

public class NumberLinkedList 
{
    public Node head;
    public Node last;
    public int size;
    
    public NumberLinkedList()
    {
        head = last = null!;
    }

    public void Add(int digit) // 3
    {
        var newNode = new Node(digit);

        if (head is null && last is null)
        {
            head = newNode;
            
            last = head;
        }

        else
        {
            last.next = newNode;

            last = newNode;
        }

        size++;
    }

    public void Print()
    {
        Console.WriteLine("==============================");

        var tempNode = head;

        for (int i = 1; i <= size; i++)
        {
            Console.Write(tempNode.digit);

            if (i != size)
                Console.Write(" => ");
            else
                Console.WriteLine("");

            tempNode = tempNode.next;
        }
        
        Console.WriteLine("==============================");
    }
}