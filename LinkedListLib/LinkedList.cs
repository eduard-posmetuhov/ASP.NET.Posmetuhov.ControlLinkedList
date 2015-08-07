using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib
{   

    public class LinkedList<T> /*: IEnumerable<T>*/
    {
        public int Count { get; private set; }
        public ListItem<T> First { get; set; }
        public ListItem<T> Last { get; set; }

        public LinkedList()
        {
            Count = 0;
            First = null;
            Last = null;
        }

        public void AddLast(ListItem<T> item)
        {
            if (First == null)
            {
                First = item;
                item.next= null;
            }
            if (Last != null)
                Last.next = item;
            item.prev = Last;
            Last = item;
            Count++;
        }

        public void AddFirst(ListItem<T> item)
        {
            if (Last == null)
            {
                Last = item;
                item.prev = null;
            }
            if (First != null)
                First.prev = item;
            item.next = First;
            First = item;
            Count++;
        }

        public bool Remove(T removeItem)
        {
            var current = First;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(removeItem))
                {
                    if (current == First)
                    {
                        First = current.next;
                        First.prev = null;
                    }
                    else
                        if (current == Last)
                        {
                            Last = current.prev;
                            Last.next = null;
                        }
                        else
                        {
                            current.prev.next = current.next;
                            current.next.prev = current.prev;
                        }
                    Count--;
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public int Find(T searchItem)
        {
            var current = First;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(searchItem))
                    return i;
                current = current.next;
            }
            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = First;
            for (var i = 0; i < Count; i++)
            {
                yield return current.Data;
                current=current.next;
            }
            
        } 
    }
}
