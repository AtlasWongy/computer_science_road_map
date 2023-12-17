namespace app.Tree;

public class FullBinaryTree
{
    private BinaryTree _binaryTree;

    public FullBinaryTree(BinaryTree binaryTree)
    {
        _binaryTree = binaryTree;
    }

    public bool isFBT(Node node)
    {
        if (node == null)
        {
            return true;
        }

        if (node.LeftNode == null && node.RightNode != null)
        {
            return false;
        } 
        else if (node.LeftNode != null && node.RightNode == null)
        {
            return false;
        }

        return isFBT(node.LeftNode) && isFBT(node.RightNode);
    }
}