using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quack
{
    public class Duck : IDuck
    {
        public Quack<T> Feed<T>(T item)
        {
            var quack = new Quack<T>();
            quack.Push(item);
            return quack;
        }
    }
}
