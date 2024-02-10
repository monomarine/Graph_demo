using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodesGraph
{
    internal class Graph
    {
        public List<Node> Nodes; //список вершин графа

        public Graph()=> Nodes = new List<Node>();

        public void AddNode(string name) =>
            Nodes.Add(new Node(name));

        public static void AddEdge(Node sourceNode,
            Node destinationNode, int weight)
        {
            sourceNode.AddEdge(destinationNode, weight);    
        }
        //дописать обход графа
    }
}
