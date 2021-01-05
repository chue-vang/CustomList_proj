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
        T[] items = new T[4];
        //needs to be read only
        public int Count
        {
            get;
            private set;
        }
        //count and capacity needs to be properties
        public int Capacity
        {
            get;
            set;
        }




        //constructor
        public CustomList()
        {
            Capacity = 0;
            Count = 0;
        }




        //member methods
        //1. add item to next available index
        //2. increment count, assuming item was added successfuly        
        //3. if count and capacity are the same, then create more space

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                
            }
            items[Count] = item;
            Count++;
        }


    }
}
