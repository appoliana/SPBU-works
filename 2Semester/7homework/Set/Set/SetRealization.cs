using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Set
{
    public class Set<T> : ISet<T> where T : IComparable
    {
        public int Count { get; private set; } = 0; 
        public bool IsReadOnly { get; }
        public List<T> _list;

        public Set()
        {
            IsReadOnly = true;
            _list = new List<T>();
        }
        public Set(bool isReadOnly)
        {
            IsReadOnly = isReadOnly;
            _list = new List<T>();
        }
        public Set(IEnumerable<T> list, bool isReadOnly)
        {
            IsReadOnly = isReadOnly;
            _list = new List<T>();
            foreach (var t in list)
            {
                _list.Add(t);
            }

            Count = _list.Count;
        }

        public IEnumerator<T> GetEnumerator() => new SetEnumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        void ICollection<T>.Add(T item)
        {
            if (!_list.Contains(item))
            {
                _list.Add(item);
            }
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException();
            }

            foreach (var t in other)
            {
                if (!_list.Contains(t))
                {
                    return true;
                }
            }

            return false;
        }

        bool ISet<T>.Add(T item)
        {
            if (_list.Contains(item))
            {
                return false;
            }
            _list.Add(item);
            return true;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item) => _list.Contains(item);
        

        public void CopyTo(T[] array, int arrayIndex)
        {
            foreach (var x in _list)
            {
                array[arrayIndex] = x;
                ++arrayIndex;
            }
        }

        public bool Remove(T item)
        {
            if (_list.Contains(item))
            {
                _list.Remove(item);
                return true;
            }
            return false;
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            foreach (var x in other)
            {
                _list.Remove(x);
            }
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new System.NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            foreach (var x in other)
            {
                if (!_list.Contains(x))
                {
                    _list.Add(x);
                }
            }
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            foreach (T x in other)
            {
                if (!_list.Contains(x))
                {
                    _list.Remove(x);
                }
            }
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            int countOther = 0;
            int countList = 0;
            foreach (T x in other)
            {
                ++countOther;
                if (!_list.Contains(x))
                {
                    return false;
                }
            }
            foreach (T x in _list)
            {
                ++countList;
            }
            if (countOther == countList)
            {
                return false;
            }
            return true;
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            int countOther = 0;
            int countList = 0;
            foreach (T x in other)
            {
                ++countOther;
                if (!_list.Contains(x))
                {
                    return false;
                }
            }
            foreach (T x in _list)
            {
                ++countList;
            }
            if (countOther == countList)
            {
                return false;
            }
            return true;
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            foreach (T x in other)
            {
                if (!_list.Contains(x))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool IsSupersetOf(IEnumerable<T> other)
        {
            foreach (T x in _list)
            {
                if (!other.Contains(x))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool Overlaps(IEnumerable<T> other)
        {
            foreach (T x in other)
            {
                if (_list.Contains(x))
                {
                    return true;
                }
            }
            return false;
        }

        public class SetEnumerator : IEnumerator<T>
        {
            private int _position = -1;
            private readonly List<T> _list;

            public SetEnumerator(Set<T> set)
            {
                _list = new List<T>();
                foreach (var t in set._list)
                {
                    _list.Add(t);
                }
            }
            public bool MoveNext()
            {
                _position++;
                return _position < _list.Count;
            }

            public void Reset()
            {
                _position = -1;
            }

            public T Current => _list[_position];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
