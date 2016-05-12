using BinaryTree.Implementation;
using System.Collections.Generic;

namespace GraphSearchAlgorithms
{
    public class DFS<T>
    {
        public BinaryTreeNode<T> FindNode(BinaryTree<T> tree, T data)
        {
            var q = new Stack<BinaryTreeNode<T>>();
            q.Push(tree.Root);

            while (q.Count > 0)
            {
                var current = q.Pop();

                if (current.IsVisited)
                {
                    continue;
                }

                current.IsVisited = true;

                if (current.Data.Equals(data))
                {
                    return current;
                }

                if (current.Left != null)
                {
                    q.Push(current.Left);
                }
                if (current.Right != null)
                {
                    q.Push(current.Right);
                }
            }

            return null;
        }
    }
}
