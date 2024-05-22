using System;

namespace MyGenericClass
{

    public class Guarda3<T>
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
    }
}