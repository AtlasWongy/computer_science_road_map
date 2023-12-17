namespace app.Tree;

public class Node
{
    private int value;
    public Node? LeftNode;
    public Node? RightNode;

    public Node(int value)
    {
        this.value = value;
    }
}