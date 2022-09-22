using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quack
{
    /// <summary>
    /// A duck is a quack factory
    /// </summary>
    public class Duck : IDuck
    {
        internal Duck()
        {
        }

        public static implicit operator Duck(Witch d) => new Duck();

        public Egg Lay()
        {
            return new Egg();
        }

        public List<Quack<T>> Feed<T>(params T[] items)
        {
            var quacks = new List<Quack<T>>();
            foreach (var item in items)
            {
                if (item.GetType() == typeof(Egg))
                {
                    throw new ObjectDisposedException(nameof(Egg));
                }

                var quack = new Quack<T>();
                quack.Push(item);
                quacks.Add(quack);
            }
            return quacks;
        }
    }
}
