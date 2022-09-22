namespace Quack
{
    public interface IDuck
    {
        protected List<Quack<T>> Feed<T>(params T[] items);
    }
}