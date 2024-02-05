using BinarySearchTree.Entities;

namespace BinarySearchTree.Utilities
{
    public static class BinarySearchTreeSearchUtility
    {
        /// <summary>
        /// Search the binary search tree for a node with a specific value
        /// </summary>
        /// <param name="rootNode">The root node of the binary search tree</param>
        /// <param name="value">The value to search for</param>
        /// <returns>The node that represents the value that has been searched</returns>
        public static SearchTreeNode Search(this SearchTreeNode rootNode, int value)
        {
            return SearchHelper(rootNode, value);
        }

        private static SearchTreeNode SearchHelper(SearchTreeNode node, int value)
        {
            if (node == null || node.NodeValue == value)
            {
                return node;
            }

            if (node.NodeValue < value)
            {
                return SearchHelper(node.RightNode, value);
            }

            return SearchHelper(node.LeftNode, value);
        }
    }
}
