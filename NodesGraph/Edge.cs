using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodesGraph
{
    /// <summary>
    /// класс ребра графа, с весом
    /// </summary>
    internal class Edge
    {
        public Node ConnectedNode { get; } //связанная вершина
        public int Weight { get; } //вес ребра

        public Edge(Node connectedNode, int weight)
        {
            this.ConnectedNode=connectedNode;
            this.Weight=weight;
        }
    }
}
