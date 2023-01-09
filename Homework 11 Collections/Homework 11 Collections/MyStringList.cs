using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11_Collections
{
    internal class MyStringList
    {
        public string[] Array => _arr;
        public MyStringList(int size = 0)
        {
            _arr = new string[size];
        }
        string[] _arr;

        public string GetValue(int i)
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

        public void Remove(string value)
        {
            var index = System.Array.IndexOf(_arr, value);

            RemoveAt(index);
        }

        public void Add(string value)
        {
            System.Array.Resize(ref _arr,_arr.Length+1);
            _arr[_arr.Length-1] = value;
        }
    }
}
