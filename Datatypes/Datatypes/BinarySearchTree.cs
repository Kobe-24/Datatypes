using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Add(T value)
        {
            if (root == null)
            {
                root = new Node<T> { Value = value, Parent = null };
                return;
            }
            Add(value, root, null);
        }

        private void Add(T value, Node<T> node, Node<T> parentNode)
        {
            if (node == null)
            {
                node = new Node<T> { Value = value, Parent = parentNode };
                //connect to parent node
                if(parentNode.Value.CompareTo(value) > 0)
                {
                    parentNode.LeftNode = node;                    
                }
                else
                {
                    parentNode.RightNode = node;
                }
            }
            else
            {
                if (node.Value.CompareTo(value) > 0)
                {
                    Add(value, node.LeftNode, node);
                }
                else
                {
                    Add(value, node.RightNode, node);
                }
            }
        }

        public bool Exists(T value)
        {
            return (Find(value, root) != null);            
        }

        public string PrintTreeInOrder()
        {
            return PrintTreeInOrder(root);   
        }

        private string PrintTreeInOrder(Node<T> node)
        {
            string toReturn = "";
            if (node == null) return toReturn;
            toReturn += PrintTreeInOrder(node.LeftNode);
            toReturn += node.Value.ToString();
            toReturn += ";";
            toReturn += PrintTreeInOrder(node.RightNode);
            return toReturn;
        }

        public void Delete(T value)
        {
            if (root == null) return;

            if (root.Value.CompareTo(value) == 0)
            {
                root = null;
                return;
            }

            Delete(value, root);
        }


        private void Delete(T value, Node<T> node)
        {
            if (node.Value.CompareTo(value) > 0)
            {
                DeleteNodeInTree(value, node, node.LeftNode);
            }
            else
            {
                DeleteNodeInTree(value, node, node.RightNode);
            }                       
        }               

        private void DeleteNodeInTree(T value, Node<T> node, Node<T> childNode)
        {
            if (EqualValue(childNode, value) && IsLeaf(childNode))
            {
                if (childNode.Parent.LeftNode != null && childNode.Parent.LeftNode.Value.CompareTo(childNode.Value) == 0)
                    childNode.Parent.LeftNode = null;
                else
                    childNode.Parent.RightNode = null;
            }
            else if (EqualValue(childNode, value))
            {
                if (node.LeftNode == null && node.RightNode != null)
                {
                    node.LeftNode = node.RightNode;
                }
                else if (node.RightNode == null && node.LeftNode != null)
                {
                    node.RightNode = node.LeftNode;
                }
                else // node has two children
                {
                    // find predecessor (most left leaf in right tree)
                    // insert and at node's place
                    // delete predecessor
                    Node<T> predecessor = FindPredecessor(node.LeftNode);
                    node.Value = predecessor.Value;
                    predecessor.Parent.LeftNode = null;
                }
            }
            else
            {
                Delete(value, childNode);
            }
        }

        private Node<T> FindPredecessor(Node<T> rightNode)
        {
            if (rightNode.LeftNode != null)
            {
                return FindPredecessor(rightNode.LeftNode);
            }
            else
            {
                return rightNode;
            }
        }

        private bool EqualValue(Node<T> node, T value)
        {
            return node.Value.CompareTo(value) == 0;
        }

        private bool IsLeaf(Node<T> node)
        {
            return node.LeftNode == null && node.RightNode == null;
        }

        private Node<T> Find(T value, Node<T> node)
        {
            if (node == null) return null;

            if (node.Value.CompareTo(value) == 0)
            {
                return node;
            }
            else if (node.Value.CompareTo(value) <= 0)
            {
                return Find(value, node.LeftNode);
            }
            else
            {
                return Find(value, node.RightNode);
            }            
        }
        
        private class Node<T>
        {
            public Node<T>LeftNode { get; set; }
            public Node<T> RightNode { get; set; }
            public Node<T> Parent { get; set; }

            public T Value { get; set; }

        }
    }
}
