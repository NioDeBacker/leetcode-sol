public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        // Use Factory Method to create DisjointSet from adj matrix
        // Return count of graphs in DisjointSet after processing adj matrix
        return DisjointSet.FromMatrix(isConnected).Graphs;
    }
}

public class DisjointSet
{
    private int[] _nodes;
    private int[] _ranks;

    public static DisjointSet FromMatrix(int[][] matrix)
    {
        var n = matrix.Length;
        if(n == 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        var set = new DisjointSet(n);
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(matrix[i][j] == 1)
                {
                    // Union two nodes if they are marked connected within matrix
                    set.Union(i, j);
                }
            }
        }

        return set;
    }
    
    public DisjointSet(int n)
    {
        _nodes = new int[n];
        _ranks = new int[n];

        // Initially we have n unconnected nodes (n graphs)
        Graphs = n;

        // Initialize nodes pointer to itself and ranks to be 1
        for(int i = 0; i < n; i++)
        {
            _nodes[i] = i;
            _ranks[i] = 1;
        }
    }

    public int Graphs { get; set; }

    public int Find(int node)
    {
        // Traverse relations untill the root node is found
        while(node != _nodes[node])
        {
            // Connect node.next to node.next.next to optimize speed
            _nodes[node] = _nodes[_nodes[node]];
            node = _nodes[node];
        }

        return node;
    }

    public void Union(int a, int b)
    {
        // Find roots of both nodes
        a = Find(a);
        b = Find(b);

        // If roots are equal it means they are already connected
        if(a == b)
        {
            return;
        }

        // Union small graph with the bigger one
        if(_ranks[a] > _ranks[b])
        {
            _nodes[b] = a;
            _ranks[a] += _ranks[b];
        }
        else
        {
            _nodes[a] = b;
            _ranks[b] += _ranks[a];
        }

        // Decrease total graphs count because we have just connected two nodes
        Graphs--;
    }
}