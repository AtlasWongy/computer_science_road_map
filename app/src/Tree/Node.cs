namespace app.Tree;

public class Node
{
    public int Value;
    public Node? LeftNode;
    public Node? RightNode;

    public Node(int value)
    {
        this.Value = value;
    }
}