using System;

namespace ConsoleApp65
{
  public class Node
  {
    public Node Next;
    public object Data;
  }

  public class LinkedList
  {
    private Node _head;

    public void PrintAllNodes()
    {
      var curNode = _head;
      while (curNode != null)
      {
        Console.WriteLine(curNode.Data);
        curNode = curNode.Next;
      }
    }

    public void AddFirst(object data)
    {
      var addNode = new Node {Data = data, Next = _head};
      _head = addNode;
    }

    public void AddLast(object data)
    {
      var curNode = _head;
      if (_head == null)
      {
        _head = new Node {Data = data, Next = null};
      }
      else
      {
        var addNode = new Node {Data = data};
        while (curNode.Next != null)
        {
          curNode = curNode.Next;
        }

        curNode.Next = addNode;
      }
    }
  }

  internal class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello Harshal Raverkar");
      var ls = new LinkedList();
      ls.AddFirst("H");
      ls.AddFirst("A");
      ls.AddFirst("R");
      ls.AddFirst("S");
      ls.AddFirst("H");
      ls.AddFirst("A");
      ls.AddFirst("L");
      ls.AddLast("R");
      ls.PrintAllNodes();

    }
  }
}


