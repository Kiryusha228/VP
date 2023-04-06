using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TreeLib
{
    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T>? _root;

        public Tree()
        {
            _root = null;
        }

        public Tree(T element)
        {
            _root = new Node<T>(element);
        }

        public Node<T>? Find(T element)
        {
            if (_root == null)
            {
                return null;
            }

            Node<T>? currentNode = _root;
            while (currentNode != null)
            {
                switch (currentNode.Data.CompareTo(element))
                {
                    case 0:
                    {
                        return currentNode;
                    }
                    case 1:
                    {
                        currentNode = currentNode.Right;
                        break;
                    }
                    case -1:
                    {
                        currentNode = currentNode.Left;
                        break;
                    }
                    default:
                    {
                        return null;
                    }
                }
            }
           return null;
        }

        public void Insert(T element)
        {
            if (_root == null)
            {
                _root = new Node<T>(element);
                return;
            }

            Insert(_root, element);
            
        }

        private void Insert(Node<T> node, T element)
        {
            switch (node.Data.CompareTo(element))
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        if (node.Right == null)
                        {
                            node.Right = new Node<T>(element);
                        }
                        else
                        {
                            Insert(node.Right, element);
                        }
                        break;
                    }
                case -1:
                    {
                        if (node.Left == null)
                        {
                            node.Left = new Node<T>(element);
                        }
                        else
                        {
                            Insert(node.Left, element);
                        }
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        public void Remove(T element)
        {
            //_root = Remove(_root!, element);
            if (_root != null)
            {
                _root = Remove(_root!, element);
            }
        }

        private Node<T>? Remove(Node<T>? node, T element)
        {
            if (node == null) // дерево пустое или элемент не найден
                return null;

            switch (element.CompareTo(node.Data))
            {
                case 0:
                    {
                        if (node.Left == null)
                            return node.Right;

                        if (node.Right == null)
                            return node.Left;

                        // у удаляемого узла есть оба потомка
                        Node<T>? minRight = FindMin(node.Right);
                        var newNode = new Node<T>(minRight.Data);
                        newNode.Left = node.Left;
                        newNode.Right = node.Right;
                        //node.Data = minRight.Data;
                        node = newNode;

                        node.Right = Remove(node.Right, minRight.Data);

                        return node;
                    }
                case 1:
                    {
                        node.Left = Remove(node.Left, element); // рекурсивно удаляем узел из левого поддерева
                        return node;
                    }
                case -1:
                    {
                        node.Right = Remove(node.Right, element); // рекурсивно удаляем узел из правого поддерева
                        return node;

                    }
                default:
                    {
                        return null;
                    }
            }         
        }

        private Node<T> FindMin(Node<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }



        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal(_root!).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> InOrderTraversal(Node<T>? node)
        {
            if (node != null)
            {
                foreach (T value in InOrderTraversal(node.Left))
                {
                    yield return value;
                }
                yield return node.Data;
                foreach (T value in InOrderTraversal(node.Right))
                {
                    yield return value;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            void Traverse(Node<T> node, string indent, bool last)
            {
                sb.Append(indent);
                if (last)
                {
                    sb.Append("└─");
                    indent += "  ";
                }
                else
                {
                    sb.Append("├─");
                    indent += "│ ";
                }
                sb.AppendLine(node.Data.ToString());

                if (node.Left != null)
                    Traverse(node.Left, indent, node.Right == null);
                else if (node.Right != null)
                {
                    sb.Append(indent);                   
                    sb.AppendLine("├─(!)");
                }

                if (node.Right != null)
                    Traverse(node.Right, indent, true);
                else if (node.Left != null)
                {
                    sb.Append(indent);
                    sb.AppendLine("└─(!)");
                }
            }

            Traverse(_root!, "", true);

            return sb.ToString();
        }

    }



}
