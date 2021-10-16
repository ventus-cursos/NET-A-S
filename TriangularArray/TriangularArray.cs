using System;

namespace Ventus
{
    public class TriangularArray<T>
    {
        private readonly T[] _data;
        private readonly int _side;

        public TriangularArray(int side)
        {
            _side = side;
            _data = new T[side * (side + 1) / 2];
        }

        public T this[int row, int column]
        {
            get { return _data[Offset(row, column)]; }
            set { _data[Offset(row, column)] = value; }
        }

        private int Offset(int row, int column)
        {
            if (row >= _side)
                throw new IndexOutOfRangeException("Row must be less than one side of the triangle.");
            if (row < column)
                throw new IndexOutOfRangeException("Row must be less than or equal to Column.");
            return row * (row + 1) / 2 + column;
        }
    }
}
