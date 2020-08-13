namespace LinkedList.src
{
    public class DNode<T>
    {
        internal T data;

        internal DNode<T> next;
        internal DNode<T> prev;

        public DNode(T data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }

        public DNode<T> NextNode => next;
        public DNode<T> PreviousNode => prev;

        public T Data => data;
    }
}
