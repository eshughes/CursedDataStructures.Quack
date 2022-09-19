namespace Quack
{
    public interface IStack<T>
    {
        public void Push(T item);
        public T Pop();
    }
}