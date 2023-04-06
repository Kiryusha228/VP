namespace TreeLib
{
    public class Node<T> where T : IComparable<T>
    {
        

        public T Data { get; }

        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }

        public Node(T val)
        {
            Data = val;
            Left = null;
            Right = null;
        }
    }
}