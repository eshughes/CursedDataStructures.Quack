namespace Quack
{
    // IQ
    public interface IQueue<T>
    {
        public void Enqueue(T item);
        public T Dequeue();
    }
}