using System;
using app.LinkedList;
using app.Tree;

namespace app
{
    internal static class Program
    {
        private static void Main()
        {
            var rootNode = new Tree.Node(7)
            {
                LeftNode = new Tree.Node(4),
                RightNode = new Tree.Node(11)
            };

            rootNode.LeftNode.LeftNode = new Tree.Node(2);
            rootNode.LeftNode.RightNode = new Tree.Node(5);

            rootNode.RightNode.LeftNode = new Tree.Node(10);
            // rootNode.RightNode.RightNode = new Tree.Node(15);

            var binaryTree = new BinaryTree(rootNode);
            var completeBinaryTree = new CompleteBinaryTree(binaryTree);
            
            Console.WriteLine(completeBinaryTree.IsCbt());

        }
    }
}