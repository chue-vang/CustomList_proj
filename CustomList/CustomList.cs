﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
        }
        //indexer
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
        //constructor
        public CustomList()
        {            
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //member methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                T[] tempArray = items;
                items = new T[capacity];
               
                for (int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
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

        public bool Remove(T item)
        {
            bool removeItem = false;
            for (int i = 0; i < count; i++)
            {
                if(item.Equals(items[i]))
                {
                    items[i] = items[i + 1];
                    removeItem = true;
                }
                else
                {
                    if (removeItem)
                    {
                        items[i] = items[i + 1];
                    }
                }
            }
            if (removeItem)
            {
                count--;
            }
            return removeItem; 
        }

        public override string ToString()
        {
            string toString = "";
            for (int i = 0; i < count; i++)
            {
                toString += items[i].ToString();
            }
            return toString;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];                
            }
        }

        public static CustomList<T> operator +(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < customList.Count; i++)
            {
                result.Add(customList[i]);
            }
            for (int i = 0; i < customListTwo.Count; i++)
            {
                result.Add(customListTwo[i]);
            }
            return result;
        }

        public static CustomList<T> operator -(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> result = new CustomList<T>();
            result = customList;
            foreach (T item in customListTwo)
            {
                result.Remove(item);
            }
            return result;
        }

        public CustomList<T> Zip(CustomList<T> customList, CustomList<T> customListTwo)
        {
            CustomList<T> result = new CustomList<T>();
            if (Count == customListTwo.Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    result.Add(customList[i]);
                    result.Add(customListTwo[i]);
                }
            }
            return result;
        }
    }
}
