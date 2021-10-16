namespace Ventus
{
    public class DynArray<T>
    {
        private T[] _array;
        private int _length;

        public DynArray() : this(4) { }

        public DynArray(int capacity)
        {
            _array = new T[capacity];
        }

        public T this[int i]
        {
            get { return _array[i]; }
            set { _array[i] = value; }
        }

        public int Length
        {
            get { return _length; }
        }

        public int Capacity
        {
            get { return _array.Length; }
        }

        public void Add(T data)
        {
            if (_length == _array.Length)
                Grow();
            _array[_length++] = data;
        }

        private void Grow()
        {
            var a = new T[_array.Length * 2];
            _array.CopyTo(a, 0);
            _array = a;
        }
    }
}
