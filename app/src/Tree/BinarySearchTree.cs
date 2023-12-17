namespace app.Tree;

public class BinarySearchTree
{
    private BinaryTree _binaryTree;

    public BinarySearchTree(BinaryTree binaryTree)
    {
        _binaryTree = binaryTree;
    }

    public bool isBST()
    {
        return isBSTUtil(_binaryTree.rootNode, Int32.MinValue, Int32.MaxValue);
    }

    private bool isBSTUtil(Node node, int min, int max)
    {
        if (node == null)
        {
            return true;
        }

        if (node.Value <= min || node.Value >= max)
        {
            return false;
        }

        return isBSTUtil(node.LeftNode, min, node.Value) && isBSTUtil(node.RightNode, node.Value, max);
    }
}