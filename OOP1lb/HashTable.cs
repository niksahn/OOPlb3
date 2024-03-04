
using System.Collections;

namespace OOP1lb
{
    public delegate void ZheckHandler(String key);

internal class MyHashTable : IEnumerable
    {
        private Hashtable _table = new Hashtable();
        public int Count {  get { return _table.Count; } }

        public event ZheckHandler objectCreated;
        public event ZheckHandler objectDeleted;

        public IEnumerator GetEnumerator() { return _table.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        public Zheck? this[String? i]
        {
            get => (Zheck?) _table[i??""];
        }
        public bool Add(Zheck zheck)
        {
            //if (_table.containskey(zheck.number1))
            //{
            //    return false;
            //}
            _table.Add(zheck.Name1, zheck);
            objectCreated?.Invoke(zheck.Name1);
            return true;
        }

        public bool Contains(String key)
        {
            return _table.ContainsKey(key);
        }

        public void Remove(String key)
        {
            objectDeleted.Invoke(key);
            _table.Remove(key);
        }
    }
}