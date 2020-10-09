using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.LinkedLists;

namespace DataStructures.Graphs
{

    public class Graph<T>
    {
        List<Vertex> Vertices = new List<Vertex>();

        public Vertex AddVertex(T value)
        {
            Vertex newVertex = new Vertex(value);
            Vertices.Add(newVertex);
            return newVertex;
        }

        public void AddEdge(Vertex v1, Vertex v2)
        {
            v1.Neighbors.AddLast(v2);
            v2.Neighbors.AddLast(v1);
        }

        public LinkedList<Vertex> GetNeighbors(Vertex v)
        {
            return v.Neighbors;
        }

        public List<Vertex> GetVertices()
        {
            return Vertices;
        }

        public int Size()
        {
            var sum = Vertices.Count;
            return sum;
        }

        public class Vertex
        {
            T Value { get; set; }

            public Vertex(T value)
            {
                this.Value = value;
                this.Neighbors = new LinkedList<Vertex>();
            }

            public LinkedList<Vertex> Neighbors { get; } = new LinkedList<Vertex>();
        }
    }
}
