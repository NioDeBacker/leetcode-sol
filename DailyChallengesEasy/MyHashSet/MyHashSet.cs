public class MyHashSet
        {
            BitArray arr;

            public MyHashSet()
            {
                arr = new BitArray(1000001);
            }

            public void Add(int key)
            {
                arr[key] = true;
            }

            public void Remove(int key)
            {
                arr[key] = false;
            }

            public bool Contains(int key)
            {
                return arr[key];
            }
        }

        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */