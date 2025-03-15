namespace app.Graph;

public class DirectedGraph
{
    public Dictionary<int, Node> Nodes = new();

    public void AddNode(int key)
    {
        Nodes[key] = new Node(key);
    }

    public void AddEdges(Node fromNode, Node toNode)
    {
        fromNode.AddNeighbour(toNode);
    }

    public void PrintGraph()
    {
        foreach (var node in Nodes)
        {
            int source = node.Key;
            List<Node> destination = node.Value.Neighbours;
            
            Console.Write($"The source: {source}");

            foreach (var dnode in destination)
            {
                Console.Write($"-> {dnode.Value}");
            }
        }
    }
}