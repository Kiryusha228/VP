using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLib
{
    public class ArrayEnumerator<T> : IEnumerator
    {
        private T[] _array;
        private int _position = -1;
        private int _count = 0;

        public ArrayEnumerator(T[] array, int count)
        {
            this._array = array; 
            this._count = count;
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _count)
                {
                    throw new ArgumentException();
                }

                return  _array[_position]!;
            }
        }

        public bool MoveNext()
        {
            if (_position < _count - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() => _position = -1;
    }
}
