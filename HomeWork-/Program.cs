using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLibray
{
    public class ArrayList<T>
    {
        private int _length { get { return _array.Length; } }
        private T[] _array;
        public int Count { get; private set; }

        public ArrayList()
        {
            _array = new T[7];
            Count = 0;
        }

        public ArrayList(int length)
        {
            _array = new T[length];
            Count = 0;
        }

        public ArrayList(T[] arr)
        {
            int length = (int)(arr.Length * 1.5);
            _array = new T[length];
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i] = arr[i];
            }
            Count = arr.Length;
        }

        public T this[int index]
        {
            get
            {
                if (index > Count - 1)
                {
                    throw new IndexOutOfRangeException($"По индексу {index} нет элемента.");
                }
                return _array[index];
            }
            set
            {
                if (index > Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public void Add(T element)
        {
            if (Count >= _array.Length)
            {
                Increathlength();
            }
            _array[Count++] = element;
        }

        private void Increathlength(int countElements = 1)
        {
            int newLength = _length;
            while (newLength <= _length + countElements)
            {
                newLength = (int)(newLength * 1.5 + countElements);
            }
            T[] newArray = new T[newLength];
            Array.Copy(_array, newArray, _length); _array = newArray;
        }
    }
}

namespace HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
