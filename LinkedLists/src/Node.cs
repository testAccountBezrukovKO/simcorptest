namespace LinkedList.src
{
    public class Node<T>
    {
        internal T data;

        internal Node<T> next;

        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }

        public Node<T> NextNode => next;

        public T Data => data;
    }
}
