using BinaryTree.Implementation;
using NUnit.Framework;

namespace GraphSearchAlgorithms.Tests
{
    [TestFixture]
    public class BFSTests
    {
        private BinaryTree<int> btree;

        [SetUp]
        public void Setup()
        {
            btree = new BinaryTree<int>();
            btree.Root = new BinaryTreeNode<int>(1);
            btree.Root.Left = new BinaryTreeNode<int>(2);
            btree.Root.Right = new BinaryTreeNode<int>(3);

            btree.Root.Left.Left = new BinaryTreeNode<int>(4);
            btree.Root.Right.Right = new BinaryTreeNode<int>(5);

            btree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
            btree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

            btree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);
        }

        [Test]
        public void BFS_FindExistingValueInTree()
        {
            var bfs = new BFS<int>();
            int expectedValue = 6;
            var node = bfs.FindNode(btree, expectedValue);

            Assert.AreEqual(expectedValue, node.Data);
        }
    }
}
