using System;

namespace BinarySearchTree.Entities
{
    public sealed class SearchTreeNode
    {
        private int _value;
        private SearchTreeNode _left;
        private SearchTreeNode _right;

        /// <summary>
        /// Creates a new <see cref="SearchTreeNode"/>,
        /// only typically used when creating the root node for the tree
        /// </summary>
        /// <param name="value">The value that the node represents</param>
        public SearchTreeNode(int value)
        {
            _value = value;
        }

        public int NodeValue { get => _value; }
        public SearchTreeNode LeftNode { get => _left; }
        public SearchTreeNode RightNode { get => _right; }

        /// <summary>
        /// Adds a node to the tree at the appropriate level
        /// </summary>
        /// <param name="value">The value to add a node for</param>
        /// <exception cref="InvalidOperationException">Thrown when the provided value is already represented in the tree</exception>
        public void AddChildNode(int value)
        {
            if (value == _value)
            {
                throw new InvalidOperationException($"SearchTreeNode: Insertion of duplicate node (value: {value})");
            }

            if (value < _value)
            {
                _left = updateNode(_left, value);
                return;
            }

            _right = updateNode(_right, value);
        }

        private SearchTreeNode updateNode(SearchTreeNode node, int value)
        {
            if (node == null)
            {
                return new SearchTreeNode(value);
            }

            node.AddChildNode(value);

            return node;
        }
    }
}
