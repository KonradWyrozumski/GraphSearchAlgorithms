using BinaryTree.Implementation;
using System.Collections.Generic;

namespace GraphSearchAlgorithms
{
    public class BFS<T>
    {
        public BinaryTreeNode<T> FindNode(BinaryTree<T> tree, T data)
        {
            var q = new Queue<BinaryTreeNode<T>>();
            q.Enqueue(tree.Root);

            while(q.Count > 0)
            {
                var current = q.Dequeue();

                if(current.IsVisited)
                {
                    continue;
                }

                current.IsVisited = true;

                if(current.Data.Equals(data))
                {
                    return current;
                }

                if(current.Left != null)
                {
                    q.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    q.Enqueue(current.Right);
                }
            }

            return null;
        }
    }
}
