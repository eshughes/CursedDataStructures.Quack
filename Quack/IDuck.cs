namespace Quack
{
    public interface IDuck
    {
        public Quack<T> Feed<T>(T item);
    }
}