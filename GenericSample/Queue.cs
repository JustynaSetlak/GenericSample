using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public class Queue<T> : IEnumerable<T>
    {
        private T[] _data;
        private int _count;
        private readonly int _size;
        private int _front;
        private int _back;
        private int _frontIndexToEnumerate;
        private int _countToEnumerate;

        public Queue(int size)
        {
            _size = size;
            _data = new T[size];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _size;
        }

        public void Enque(T item)
        {
            if (IsFull()) throw new Exception("Queue is full");
            _data[_back] = item;
            _count++;
            _back = (++_back) % _size;
            var z = _back;
        }

        public T Dequeue()
        {
            if(IsEmpty()) Console.WriteLine("Queue is empty");
            T element = _data[_front];
            _data[_front] = default(T);
            _count--;
            _front = ++_front % _size;
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            _countToEnumerate = _count;
            _frontIndexToEnumerate = _front;

            while (_countToEnumerate > 0)
            {
                yield return GetElement();
            }
        }

        public T GetElement()
        {
            T element = _data[_frontIndexToEnumerate];
            _countToEnumerate--;
            _frontIndexToEnumerate = ++_frontIndexToEnumerate % _size;
            return element;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
