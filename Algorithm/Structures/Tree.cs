﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Algorithm.Structures
{
    public class Tree<T> : AlgorithmBase<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public int Count { get; private set; }

        public Tree() { }
        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Items.Add(item);

                var node = new Node<T>(item, i);
                Add(node);
            }
              
        }

        private void Add(Node<T> node)
        {
            if(Root == null)
            {
                Root = node;
                Count++;
                return;
            }
            else
            {
                Add(Root, node);
                Count++;
            }
        }

        private void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                    return;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }

        protected override void MakeSort()
        {
            var result = Inorder(Root).Select(r => r.Data).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }

        private List<Node<T>> Inorder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }

            return list;
        }
    }
}
