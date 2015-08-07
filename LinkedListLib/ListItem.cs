using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib
{
    public class ListItem<T>
    {
        public ListItem(T data)
        {
            this.Data = data;
        }
        public T Data { get; private set; }
        public ListItem<T> prev { get; set; }
        public ListItem<T> next { get; set; }
    }
}
