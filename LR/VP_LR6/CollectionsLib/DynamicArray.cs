using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Xml.Linq;

namespace CollectionsLib
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _array;

        private int _count;

        public int Count
        {
            get 
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }
        public DynamicArray() 
        {
            _array = new T[20];
        }

        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
        }

        public void Add(T element)
        {
            if (_count == Capacity)
            {
                IncreaseCapacity(20);
            }
            _array[_count++] = element;
        }

        public void Add(IEnumerable<T> elements)
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                Add(elements.ElementAt(i));
            }
        }

        public void Insert(T element, int position)
        {
            for (int i = _count - 1; i >= position; i--)
            {
                _array[i+1] = _array[i];
            }
            _array[position] = element;
            _count++;
        }

        public void RemoveAt(int position)
        {
            for (int i = position; i < Count - 1; i++)
            {
                _array[i] = _array[i+1];
            }
            _array[--_count] = default(T)!;
        }

        public void IncreaseCapacity(int n)
        {
            var tmpArray = new T[Capacity + n];
            for (int i = 0; i < _count - 1; i++)
            {
                tmpArray[i] = _array[i];
            } 
            _array = tmpArray;
        }

        public override string ToString()
        {
            if (Count == 0)
            {
                return String.Empty;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                for (int i = 0; i < Count - 1; i++)
                {
                    sb.Append($"{_array[i]}, ");
                }
                sb.Append($"{_array[Count - 1]}]");
                return sb.ToString();
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < array.Length - arrayIndex ; i++)
            {
                array[i+arrayIndex] = _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => new ArrayEnumerator<T>(_array);

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _array[i];
            }
        }

        public void Filter(Func<T, bool> function)
        {
            for (int i = 0; i < Count; i++)
            {
                if (function(_array[i]))
                {
                    RemoveAt(i--);
                }
            }
        }

        public void Sort(Func<T, T, int> CompareTo)
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count - 1; j++)
                {
                    if (CompareTo(_array[j], _array[j + 1]) > 0)
                    {
                        (_array[j], _array[j + 1]) = (_array[j + 1], _array[j]);
                    }
                }
            }
        }

    }
}