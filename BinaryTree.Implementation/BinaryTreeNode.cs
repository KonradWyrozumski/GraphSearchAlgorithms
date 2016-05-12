namespace BinaryTree.Implementation
{
    public class BinaryTreeNode<T> : Node<T>
    {
        private const int rightNode = 1;
        private const int leftNode = 0;
        private bool isVisited;

        public BinaryTreeNode() : base() { }
        public BinaryTreeNode(T data) : base(data, null) { }
        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            base.Data = data;
            NodeList<T> children = new NodeList<T>(2);
            children[leftNode] = left;
            children[rightNode] = right;
            base.Neighbors = children;

            this.IsVisited = false;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[0];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[leftNode] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (base.Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>)base.Neighbors[1];
            }
            set
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>(2);

                base.Neighbors[rightNode] = value;
            }
        }

        public bool IsVisited
        {
            get
            {
                return isVisited;
            }

            set
            {
                isVisited = value;
            }
        }
    }
}
