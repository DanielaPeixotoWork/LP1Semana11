using System;
using System.Collections;
using System.Collections.Generic;

namespace MyOwnCollection
{
    public class ShortQueue<T> : ICollection<T>
    {
        private readonly Queue<T> _queue;
        private readonly int _capacity;

        public ShortQueue() : this(5) { }

        public ShortQueue(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");

            _capacity = capacity;
            _queue = new Queue<T>(capacity);
        }

        public int Count => _queue.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (_queue.Count == _capacity)
            {
                _queue.Dequeue(); 
            }
            _queue.Enqueue(item);
        }

        public void Clear()
        {
            _queue.Clear();
        }

        public bool Contains(T item)
        {
            return _queue.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _queue.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (_queue.Contains(item))
            {
                var items = _queue.ToArray();
                _queue.Clear();
                bool removed = false;

                foreach (var i in items)
                {
                    if (!removed && EqualityComparer<T>.Default.Equals(i, item))
                    {
                        removed = true; 
                    }
                    else
                    {
                        _queue.Enqueue(i);
                    }
                }
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

