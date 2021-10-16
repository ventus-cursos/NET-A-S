using System;

namespace Ventus
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private TreeNode<T> _root;

        public void Add(T data)
        {
            if (_root == null)
                _root = new TreeNode<T>(data);
            else
                Add(new TreeNode<T>(data), _root);
        }

        private void Add(TreeNode<T> newNode, TreeNode<T> parentNode)
        {
            var cmp = newNode.Data.CompareTo(parentNode.Data);
            if (cmp < 0)
            {
                if (parentNode.Left == null)
                    parentNode.Left = newNode;
                else
                    Add(newNode, parentNode.Left);
            }
            else if (cmp > 0)
            {
                if (parentNode.Right == null)
                    parentNode.Right = newNode;
                else
                    Add(newNode, parentNode.Right);
            }
        }

        public void Traverse(Action<T> visit)
        {
            Traverse(_root, visit);
        }

        private void Traverse(TreeNode<T> node, Action<T> visit)
        {
            if (node != null)
            {
                Traverse(node.Left, visit);
                visit(node.Data);
                Traverse(node.Right, visit);
            }
        }

        public bool Find(T data)
        {
            return Find(data, _root);
        }

        private bool Find(T data, TreeNode<T> root)
        {
            if (root == null) return false;
            var cmp = data.CompareTo(root.Data);
            Console.WriteLine("{0} vs {1}", data, root.Data);
            if (cmp == 0)
                return true;
            if (cmp < 0)
                return Find(data, root.Left);
            if (cmp > 0)
                return Find(data, root.Right);
            return false;
        }
    }
}
