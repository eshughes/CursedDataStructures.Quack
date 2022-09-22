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
        /// <returns></returns>
        public void Push(T item)
        {
            _quack.AddFirst(item);
        }


        /// <summary>
        /// Retrieve item from the head
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
        public void Enqueue(T item)
        {
            _quack.AddLast(item); 
        }

        /// <summary>
        /// Retrieve item from the head
        /// </summary>
        /// <returns></returns>
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
    }
}