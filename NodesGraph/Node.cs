using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodesGraph
{
    internal class Node
    {
        public string Name { get; } //имя вершины
        public List<Edge> Edges { get; } //список ребер из вершины

        public Node(string name)
        {
            this.Name = name;
            Edges = new List<Edge>();   
        }

        public void AddEdge(Node connectedNode, int weight)
        {
            Edges.Add(new  Edge(connectedNode, weight)); 
        }

        public override string ToString()
        {
            string res = $"{this.Name}\n";
            foreach (Edge edge in Edges)
            {
                res+= $"\tсвязан с ребром {edge.ConnectedNode}\t" +
                    $"\tвес ребра: {edge.Weight}";
            }

            return res ;    
        }
    }
}
