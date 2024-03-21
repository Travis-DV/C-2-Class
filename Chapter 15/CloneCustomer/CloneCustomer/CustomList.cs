using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneCustomer
{

    internal class CustomList<T> : IEnumerable<T>
    {
        private List<T> list = new();
        public int Count { get { return list.Count; } }

        public void Add(T item) => list.Add(item);

        public T this[int index] => list[index];

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in list) yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
