namespace Ventus
{
    public class TreeNode<T>
    {
        public T Data { get; set; }

        public TreeNode(T data)
        {
            Data = data;
        }

        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Left { get; set; }
    }
}