using System;
namespace ConsoleApp24
{
  class Node
  {
    public int key;
    public Node right, left;

    public Node(int key)
    {
      this.key = key;
      right = right = null;
    }
  }
  class BinaryTree
  {
    Node root;

    public BinaryTree()
    {
      this.root = null;
    }

    void PrintPostOrder(Node node)
    {
      if (node == null)
        return;
      PrintPostOrder(node.left);
      PrintPostOrder(node.right);

      Console.Write(node.key + " ");
    }

    void PrintInOrder(Node node)
    {
      if (node == null)
        return;
      PrintInOrder(node.left);
      Console.Write(node.key + " ");
      PrintInOrder(node.right);
    }

    void PrintPreOrder(Node node)
    {
      if (node == null)
        return;
      Console.Write(node.key + " ");
      PrintPreOrder(node.left);
      PrintPreOrder(node.right);
    }

    void PrintPostOrder() { PrintPostOrder(root); }
    void PrintInOrder() { PrintInOrder(root); }
    void PrintPreOrder() { PrintPreOrder(root); }

    public static void Main()
    {
      BinaryTree binaryTree = new BinaryTree();
      binaryTree.root = new Node(1);
      binaryTree.root.left = new Node(2);
      binaryTree.root.right = new Node(3);
      binaryTree.root.left.left = new Node(4);
      binaryTree.root.left.right = new Node(5);

      Console.WriteLine("Preorder traversal " +
                       "of binary tree is ");
      binaryTree.PrintPreOrder();

      Console.WriteLine("\nInorder traversal " +
                          "of binary tree is ");
      binaryTree.PrintInOrder();

      Console.WriteLine("\nPostorder traversal " +
                            "of binary tree is ");
      binaryTree.PrintPostOrder();
    }
  }
}

