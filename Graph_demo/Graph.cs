using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_demo
{
    internal class Graph
    {
        public int Size { get;set; } //размер графа
        public int[,] Adjacency { get; set; } //матрица смежности графа
        public bool[] Visited { get; set; } //вектор посещенных вершин

        public Graph(int size, int[,] adj) 
        {
            this.Size = size;
            this.Adjacency = adj;
            this.Visited = new bool[size];
        }
        //добавить вершины - даннные
        public void Depth(int i)
        {
            Visited[i] = true;
            Console.Write(i+"->");
            for(int k = 0; k< Size; k++)
            {
                if (Adjacency[i,k]==1 && !Visited[k])
                {
                    Depth(k);
                }
            }
        }
        

    }
}
