namespace Graph_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {0,1,1,0,0,0 },
                {0,0,1,0,0,1 },
                {1,0,0,1,1,0 },
                {0,0,0,0,0,0 },
                {0,0,0,0,0,1 },
                {0,0,0,0,0,0 }
            };
            Graph graph = new Graph(6, array);
            graph.Depth(5);
        }
    }
}