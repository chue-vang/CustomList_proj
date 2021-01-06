using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        public T[] items;
        private int count;
        private int capacity;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        //CustomList<int> myCustomList = new CustomList<int>() {1, 2, 3};
        //myCustomList.items [1, 2, 3]
        //myCustomList[0]


        //constructor
        public CustomList()
        {            
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //member methods
        //1. add item to next available index
        //2. increment count, assuming item was added successfuly        
        //3. if count and capacity are the same, then create more space
        //4. use a for loop to add new items to list??

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity += (capacity * 2);
                T[] tempArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = item;
                }
                items[count] = item;
                count++;
            }
            else
            {
                items[count] = item;
                count++;
            }
        }
    }
}
