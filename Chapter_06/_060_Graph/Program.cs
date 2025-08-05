namespace _060_Graph
{
    class VertexNode
    {
        public bool Visited { get; set; }                    //标记是否被访问
        public readonly string City;                         //城市名称
        public AdjacencyNode FirstNode { get; set; }         //邻接表头节点
        public VertexNode(string city)
        {
            Visited = false;
            this.City = city;
        }
    }
    class AdjacencyNode
    {
        public readonly VertexNode Vertex;               //节点指向的顶点
        public AdjacencyNode Next { get; set; }          //节点指向的下一节点
        public AdjacencyNode(VertexNode vertex, AdjacencyNode next)
        {
            this.Vertex = vertex;
            this.Next = next;
        }
    }
    class AdjacencyList
    {
        VertexNode[] vertexes;                               //顶点顺序表
        public VertexNode this[int index]                    //检索指定顶点
        {
            get { return vertexes[index]; }
        }
        public AdjacencyList(string[] cities)
        {
            vertexes = new VertexNode[cities.Length];         //创建顶点顺序表
            for (int i = 0; i < cities.Length; i++)
            {
                vertexes[i] = new VertexNode(cities[i]);       //创建顶点
            }
        }
        public void AddEdge(string city1, string city2)      //在两个城市间建立连接
        {
            VertexNode vertex1 = null, vertex2 = null;
            // 在图中寻找城市1和城市2对应的顶点
            foreach (var item in vertexes)
            {
                if (vertex1 == null && item.City == city1) vertex1 = item;
                if (vertex2 == null && item.City == city2) vertex2 = item;
            }
            // 如果城市1或城市2不存在，或者两者相同，则不建立连接
            if (vertex1 == null || vertex2 == null || vertex1 == vertex2) return;
            // 引用城市1的邻接表头节点
            AdjacencyNode node = vertex1.FirstNode;
            while (node != null)                              //检测边是否已经存在
            {
                // 如果城市1的邻接表中已经存在城市2，则不建立连接
                if (node.Vertex == vertex2) return;
                // 继续遍历城市1的邻接表
                node = node.Next;
            }
            // 如果在城市1的邻接表中没有找到城市2，则建立连接
            //将城市2插入到城市1的邻接表中
            vertex1.FirstNode = new AdjacencyNode(vertex2, vertex1.FirstNode);
            //将城市1插入到城市2的邻接表中
            vertex2.FirstNode = new AdjacencyNode(vertex1, vertex2.FirstNode);
        }
        public void DepthFirstSearch()                       //深度优先遍历
        {
            foreach (VertexNode vertex in vertexes)
            {
                DepthFirstSearchVertex(vertex);                //深度优先遍历顶点
            }
        }
        void DepthFirstSearchVertex(VertexNode vertex)       //深度优先遍历顶点
        {
            if (vertex == null || vertex.Visited) return;
            Console.Write(vertex.City + "\t");
            vertex.Visited = true;
            AdjacencyNode node = vertex.FirstNode;            //第一个邻接节点
            while (node != null)
            {
                DepthFirstSearchVertex(node.Vertex);           //深度优先遍历顶点
                node = node.Next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "北京", "上海", "天津", "重庆", "武汉", "深圳", "成都", "西安" };
            AdjacencyList graph = new AdjacencyList(cities);
            graph.AddEdge(cities[0], cities[1]);                    //连北京接到上海
            graph.AddEdge(cities[0], cities[2]);                    //连北京接到天津
            graph.AddEdge(cities[1], cities[3]);                    //连上海接到重庆
            graph.AddEdge(cities[1], cities[4]);                    //连上海接到武汉
            graph.AddEdge(cities[2], cities[5]);                    //连天津接到深圳
            graph.AddEdge(cities[2], cities[6]);                    //连天津接到成都
            graph.AddEdge(cities[3], cities[7]);                    //连重庆接到西安
            graph.AddEdge(cities[4], cities[7]);                    //连武汉接到西安
            graph.AddEdge(cities[5], cities[6]);                    //连深圳接到成都
            graph.DepthFirstSearch();
        }
    }
}
