
using System.Collections;

namespace OOP1lb
{
    public delegate void ZheckHandler(String key);

internal class MyHashTable : IEnumerable
    {
        /// <summary>
        /// Экземпляр
        /// </summary>
        private static readonly MyHashTable instance = new MyHashTable();

        private Hashtable _table;
        public int Count {  get { return _table.Count; } }


        /// <summary>
        /// Текущее значение
        /// </summary>
        public static MyHashTable Current => instance;

        public event ZheckHandler objectCreated;
        public event ZheckHandler objectDeleted;

        private MyHashTable()
        {
            _table = new Hashtable();
        }

        public IEnumerator GetEnumerator() { return _table.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        public Zheck? this[String? i]
        {
            get => (Zheck?) _table[i??""];
            set => _table[i ?? ""] = value;
        }
        public bool Add(Zheck zheck)
        {
            if (_table.ContainsKey(zheck.Number1))
            {
                return false;
            }
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
            objectDeleted(key);
            _table.Remove(key);
        }
    }
}