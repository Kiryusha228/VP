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

        public ArrayEnumerator(T[] array) => this._array = array; 

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _array.Length)
                {
                    throw new ArgumentException();
                }

                return  _array[_position]!;
            }
        }

        public bool MoveNext()
        {
            if (_position < _array.Length - 1)
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
