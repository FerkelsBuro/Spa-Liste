using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services
{
    public class RandomService
    {
        private readonly Random _random = new Random();

        public T GetRandomItem<T>(IEnumerable<T> collection)
        {
            if (collection.Count() == 0) return default(T);

            return collection.ElementAt(_random.Next(0, collection.Count()));
        }
    }
}