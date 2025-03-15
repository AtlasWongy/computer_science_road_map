namespace app.Graph;

public class Node
{
   public int Value { get; }
   public List<Node> Neighbours = new();

   public Node(int value)
   {
      Value = value;
   }

   public void AddNeighbour(Node node)
   {
      Neighbours.Add(node);
   }
}