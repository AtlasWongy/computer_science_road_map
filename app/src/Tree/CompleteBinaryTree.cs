namespace app.Tree;

public class CompleteBinaryTree
{
    private BinaryTree _binaryTree;

    public CompleteBinaryTree(BinaryTree binaryTree)
    {
        _binaryTree = binaryTree;
    }

    public bool IsCbt()
    {
        var queue = new Queue<Node>();
        queue.Enqueue(_binaryTree.rootNode);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            if (currentNode == null)
            {
                while (queue.Count > 0)
                {
                    var temp = queue.Dequeue();
                    if (temp != null)
                    {
                        return false;
                    }
                }
            }
            else
            {
                queue.Enqueue(currentNode.LeftNode);
                queue.Enqueue(currentNode.RightNode);
            }
        }

        return true;
    }
}