using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLibray
{
    public class ArrayList
    {
        private int _length { get { return _array.Length; } }
        private int[] _array;
        public int Count { get; private set; }

        public ArrayList()
        {
            _array = new int[7];
            Count = 0;
        }

        public ArrayList(int length)
        {
            _array = new int[length];
            Count = 0;
        }

        public ArrayList(int[] arr)
        {
            int length = (int)(arr.Length * 1.5);
            _array = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                _array[i] = arr[i];
            }
            Count = arr.Length;
        }

        public int this[int index]
        {
            get
            {
                if (index > Count - 1)
                {
                    throw new Exception($"row 41, по индексу:{index} нет элемента");
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

        public void Add(int element)
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
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, _length); _array = newArray;
        }

        public void Add(int element, int index)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс находится за пределами диапазона");
            }

            if (Count >= _array.Length)
            {
                Increathlength();
            }

            for (int i = Count; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;
            Count++;
        }
        public void DecreaseLength()
        {
            int newLength = (int)(_array.Length * 0.9); // Уменьшим размер на 10%
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, newLength);
            _array = newArray;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс находится за пределами диапазона");
            }

            for (int i = index; i < Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            Count--;
        }
        public void Remove(int element)
        {
            int newIndex = 0;
            for (int i = 0; i < Count; i++)
            {
                if (_array[i] != element)
                {
                    _array[newIndex++] = _array[i];
                }
            }

            Count = newIndex;
        }
        public int FindMax()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Список пуст.");
            }

            int max = _array[0];
            for (int i = 1; i < Count; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }

            return max;
        }

        public int FindMin()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Список пуст.");
            }

            int min = _array[0];
            for (int i = 1; i < Count; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
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
