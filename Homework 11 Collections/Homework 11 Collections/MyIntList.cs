using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11_Collections
{
    internal class MyIntList
    {
        public int[] Array => _arr;
        public MyIntList(int size = 0)
        {
            _arr = new int[size];
        }
        int[] _arr;

        public int GetValue(int i)
        {
            return _arr[i];
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            System.Array.Resize(ref _arr, _arr.Length - 1);
        }

        public void Remove(int value)
        {
            var index = System.Array.IndexOf(_arr, value);

            RemoveAt(index);
        }

        public void Add(int value)
        {
            System.Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }
}
