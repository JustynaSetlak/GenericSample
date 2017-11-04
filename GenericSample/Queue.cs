using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public class Queue<T>
    {
        private T[] _data;
        private int _count;
        public int Size { get;  }
        private int _first;
        private int _last;

        public Queue(int size)
        {
            Size = size;
            _data = new T[size];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == Size;
        }

        public void Enque(T item)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Queue is full");
            }
            _data[_last] = item;
            _count++;
            _last = (++_last) % Size;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T element = _data[_first];
            _data[_first] = default(T);
            _count--;
            _first = ++_first % Size;
            return element;
        }
    }
}
