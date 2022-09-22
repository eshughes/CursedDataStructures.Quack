namespace Quack
{
    public interface IDuck
    {
        protected Quack<T> Feed<T>(T item);
    }
}