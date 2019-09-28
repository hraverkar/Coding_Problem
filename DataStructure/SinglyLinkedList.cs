using System;
using System.Collections.Generic;

namespace ConsoleApp114
{
  internal class Node
  {
    public Node Next;
    public object Data;
  }

  public class LinkedList
  {
    private Node _head;

    public void AddFirst(object data)
    {
      var toAdd = new Node
      {
        Data = data,
        Next = _head
      };
      _head = toAdd;
    }

    public void AddLast(object data)
    {
      if (_head == null)
      {
        _head = new Node
        {
          Data = data,
          Next = null
        };
      }
      else
      {
        var toAdd = new Node
        {
          Data = data
        };
        var current = _head;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = toAdd;
      }
    }

    public void Print()
    {
      var current = _head;
      while (current != null)
      {
        Console.Write("-->" + current.Data);
        current = current.Next;
      }
    }
  }

  internal static class Program
  {
    public static void Main()
    {
      var link = new LinkedList();
      link.AddFirst(4);
      link.AddFirst(6);
      link.AddFirst(8);
      link.AddFirst("Hello");
      link.Print();
    }
  }
}
