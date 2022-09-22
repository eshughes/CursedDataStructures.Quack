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

        /// <summary>
        /// Insert item at the head
        /// </summary>
        public void Push(T item)
        {
            _quack.AddFirst(item);
        }

        /// <summary>
        /// Retrieve item from the head
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var head = _quack.First();
            _quack.RemoveFirst();
            return head;
        }

        /// <summary>
        /// Insert item at the tail
        /// </summary>
        public void Enqueue(T item)
        {
            _quack.AddLast(item); 
        }

        /// <summary>
        /// Retrieve item from the head
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var head = _quack.First();
            _quack.RemoveFirst();
            return head;
        }

        /// <summary>
        /// Move item from head to tail
        /// </summary>
        public void QueueHop()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var tail = _quack.Last();
            _quack.RemoveLast();
            _quack.AddFirst(tail);
        }

        /// <summary>
        /// Move item from tail to head
        /// </summary>
        public void Requeue()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException();
            }

            var head = _quack.First();
            _quack.RemoveFirst();
            _quack.AddLast(head);
        }
    }
}