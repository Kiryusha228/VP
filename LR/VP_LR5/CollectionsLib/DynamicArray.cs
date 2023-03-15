using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Xml.Linq;

namespace CollectionsLib
{
    public class DynamicArray<T> : IEnumerable<T> where T : IComparable<T>
    {
        private T[] _array;

        private int _capacity;

        private int CountOfElements()
        {
            int count = 0;
            for (int i = 0; i < Capacity; i++)
            {
                if (_array[i].CompareTo(default(T)) != 0)
                {
                    count = i + 1;
                }
            }
            return count;
        }



        public int Count
        {
            get 
            {
                return CountOfElements();
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            private set 
            {
                _capacity = value;
            }
        }
        public DynamicArray() 
        {
            Capacity = 20;
            _array = new T[Capacity];
        }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            _array = new T[Capacity];
        }

        public void Add(T element)
        {
            if (Count == Capacity)
            {
                IncreaseCapacity(20);
            }
            _array[Count] = element;
        }

        public void Add(IEnumerable<T> elements)
        {
            if (Count == Capacity)
            {
                IncreaseCapacity(20);
            }
            for (int i = 0; i < elements.Count(); i++)
            {
                Add(elements.ElementAt(i));
            }
        }

        public void Insert(T element, int position)
        {
            for (int i = Count - 1; i >= position; i--)
            {
                _array[i+1] = _array[i];
            }
            _array[position] = element;
        }

        public void RemoveAt(int position)
        {
            _array[position] = default(T)!;
        }

        public void RemoveAtAndShift(int position)
        {
            for (int i = position; i < Count - 1; i++)
            {
                _array[i] = _array[i+1];
            }
            _array[Count - 1] = default(T)!;
        }

        public void IncreaseCapacity(int n)
        {
            var tmpArray = new T[Capacity + n];
            for (int i = 0; i < Count - 1; i++)
            {
                tmpArray[i] = _array[i];
            } 
            _array = tmpArray;
            Capacity += n;
        }

        public override string ToString()
        {
            if (Count == 0)
            {
                return "Массив пуст";
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




        IEnumerator IEnumerable.GetEnumerator() => new ArrayEnumerator<T>(_array, Count);

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }
    }
}