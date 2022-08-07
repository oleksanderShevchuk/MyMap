﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Map
{
    public class EasyMap<TKey, TValue> : IEnumerable
    {
        private List<Item<TKey, TValue>> Items = new List<Item<TKey, TValue>>();
        private List<TKey> Keys = new List<TKey>();
        public EasyMap() { }
        public void Add(Item<TKey, TValue> item)
        {
            if (!Keys.Contains(item.Key))
            {
                Keys.Add(item.Key);
                Items.Add(item);
            }
        }
        public TValue Search(TKey key)
        {
            if (Keys.Contains(key))
            {
                return Items.Single(i => i.Key.Equals(key)).Value;
            }
            return default(TValue);
        }
        public void Remove(TKey key)
        {
            if (Keys.Contains(key))
            {
                Keys.Remove(key);
                Items.Remove(Items.Single(i => i.Key.Equals(key)));
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
