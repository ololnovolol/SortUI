using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithm.Structures
{
    public class Node<T> where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Right { get;  set; }
        public Node<T> Left { get;  set; }
        public int Index { get; set; }

        public Node(T data, int index)
        {
            Data = data;
            Index = index;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
