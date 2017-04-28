using System;

namespace DS
{
    public class StackArray<T>
    {
        T[] array;

        public int Count { get; internal set; }

        public StackArray() : this(0) { }

        public StackArray(int count)
        {
            array = new T[count];
            Count = count;
        }

        public bool IsEmpty()
        {
            return array.Length == 0 ? true : false;
        }

        void Increase()
        {
            int length = array.Length == 0 ? 4 : array.Length << 1;
            T[] newarray = new T[length];
            array.CopyTo(newarray, 0);
            array = newarray;
        }

        public void Push(T item)
        {
            if (Count == array.Length)
                Increase();
            array[Count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidCastException("Stack is empty");
            T item = array[--Count];
            array[Count] = default(T);
            return item;
        }

        public T Peek()
        {
            return array[Count - 1];
        }
    }
}
