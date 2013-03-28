﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyCollections.BloomFilter
{
    class BloomFilterSlice<T>
        :IBloomFilter<T>
    {
        private readonly BloomFilter<T> _filter;
        private readonly int _capacity;

        public int Count
        {
            get { return _filter.Count; }
        }

        public int SizeInBytes
        {
            get { return _filter.Size; }
        }

        public BloomFilterSlice(int capacity, double falsePositiveProbability)
        {
            _filter = new BloomFilter<T>(capacity, falsePositiveProbability);
            _capacity = capacity;
        }

        internal bool IsFull()
        {
            return _filter.Count >= _capacity;
        }

        public bool Add(T item)
        {
            return _filter.Add(item);
        }

        public bool Contains(T item)
        {
            return _filter.Contains(item);
        }

        public void Clear()
        {
            _filter.Clear();
        }
    }
}
