namespace app.Tree;

public class BinaryTree
{
    public Node rootNode;

    public BinaryTree(Node node)
    {
        this.rootNode = node;
    }

    public void PreorderTraversal(Node rootNode)
    {
        Console.WriteLine(rootNode.Value);

        if (rootNode.LeftNode != null)
        {
            PreorderTraversal(rootNode.LeftNode);
        }

        if (rootNode.RightNode != null)
        {
            PreorderTraversal(rootNode.RightNode);
        }
    }

    public void InorderTraversal(Node rootNode)
    {
        if (rootNode.LeftNode != null)
        {
            InorderTraversal(rootNode.LeftNode);
        }
        
        Console.WriteLine(rootNode.Value);

        if (rootNode.RightNode != null)
        {
            InorderTraversal(rootNode.RightNode);
        }
    }

    public void PostOrderTraversal(Node rootNode)
    {
        if (rootNode.LeftNode != null)
        {
            PostOrderTraversal(rootNode.LeftNode);
        }

        if (rootNode.RightNode != null)
        {
            PostOrderTraversal(rootNode.RightNode);
        }
        
        Console.WriteLine(rootNode.Value);
    }

    public void BfsTraversal(Node rootNode)
    {
        var queue = new Queue<Node>();
        queue.Enqueue(rootNode);
        
        Console.WriteLine("BFS Traversal: ");

        while (queue.Count != 0)
        {
            Node currentNode = queue.Dequeue();
            Console.WriteLine("This is the current Node -> " + currentNode.Value);

            if (currentNode.LeftNode != null)
            {
                queue.Enqueue(currentNode.LeftNode);
            }

            if (currentNode.RightNode != null)
            {
                queue.Enqueue(currentNode.RightNode);
            }
        }
        
    }
}