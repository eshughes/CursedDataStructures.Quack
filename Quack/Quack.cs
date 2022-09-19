namespace Quack
{
    // a joke gone too far
    public class Quack<T> : IStack<T>, IQueue<T>
    {
        private LinkedList<T> _quack;

        public Quack()
        {
            _quack = new LinkedList<T>();
        }

        public bool IsEmpty()
        {
            return _quack.Count == 0;
        }

        public void Push(T item)
        {
            _quack.AddFirst(item);
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var removed = _quack.First();
            _quack.RemoveFirst();
            return removed;
        }

        public void Enqueue(T item)
        {
            _quack.AddLast(item); 
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var removed = _quack.First();
            _quack.RemoveFirst();
            return removed;
        }
    }
}