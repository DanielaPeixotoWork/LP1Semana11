using System;

namespace JustLikeACollection
{

    public class Guarda3<T> : IEnumerable<T>
    {
        private T _item1;
        private T _item2;
        private T _item3;

        public Guarda3()
        {
            _item1 = default(T);
            _item2 = default(T);
            _item3 = default(T);
        }

        public T GetItem(int i)
        {

            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException("Index must be 0, 1, or 2.");

            return i switch
            {
                0 => _item1,
                1 => _item2,
                2 => _item3,
                _ => throw new IndexOutOfRangeException("Index must be 0, 1, or 2."),
            };
        }

        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException("Index must be 0, 1, or 2.");

            switch (i)
            {
                case 0:
                    _item1 = item;
                    break;
                case 1:
                    _item2 = item;
                    break;
                case 2:
                    _item3 = item;
                    break;
            }
        }

        public void Add(T item)
        {
            if (EqualityComparer<T>.Default.Equals(_item1, default(T)))
            {
                _item1 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(_item2, default(T)))
            {
                _item2 = item;
            }
            else if (EqualityComparer<T>.Default.Equals(_item3, default(T)))
            {
                _item3 = item;
            }
            else
            {
                throw new InvalidOperationException("No space to add new item.");
            }
        }

              public IEnumerator<T> GetEnumerator()
        {
            yield return _item1;
            yield return _item2;
            yield return _item3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

       class Program
    {
        static void Main(string[] args)
        {
            var stringGuarda = new Guarda3<string>();
            stringGuarda.SetItem(0, "first");
            stringGuarda.SetItem(1, "second");
            stringGuarda.SetItem(2, "third");

            Console.WriteLine("Guarda3<string> items:");
            foreach (var item in stringGuarda)
            {
                Console.WriteLine(item);
            }

            var floatGuarda = new Guarda3<float>();
            floatGuarda.SetItem(0, 1.1f);
            floatGuarda.SetItem(1, 2.2f);
            floatGuarda.SetItem(2, 3.3f);

            Console.WriteLine("\nGuarda3<float> items:");
            foreach (var item in floatGuarda)
            {
                Console.WriteLine(item);
            }
        }
    }
}