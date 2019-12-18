using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3_Triangles.TrianglesCore
{
    class TriangleContainer: IEnumerable<Triangle>
    {
        public SortedSet<Triangle> _triangles;

        public TriangleContainer()
        {
            _triangles = new SortedSet<Triangle>(new TriangleComparer());
        }

        public void AddTriangle(string name, double sideA, double sideB, double sideC)
        {
            _triangles.Add(Triangle.CreateTriangle(name, sideA, sideB, sideC));
        }

        public IEnumerator<Triangle> GetEnumerator()
        {
            foreach(var triangle in _triangles)
            {
                yield return triangle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
