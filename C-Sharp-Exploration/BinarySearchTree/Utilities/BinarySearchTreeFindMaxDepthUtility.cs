using BinarySearchTree.Entities;
using System;

namespace BinarySearchTree.Utilities
{
    public static class BinarySearchTreeFindMaxDepthUtility
    {
        /// <summary>
        /// Follows all branches of the tree to find the maximum depth
        /// </summary>
        /// <param name="rootNode">The binary search tree (<see cref="SearchTreeNode"/>) to be inspected</param>
        /// <returns>Integer representing the maximum depth of the tree</returns>
        public static int MaxDepth(this SearchTreeNode rootNode)
        {
            return MaxDepthCalculator(rootNode);
        }

        private static int MaxDepthCalculator(SearchTreeNode node)
        {
            if (node == null) return 0;
            return Math.Max(1 + MaxDepthCalculator(node.LeftNode), 1 + MaxDepthCalculator(node.RightNode));
        }
    }
}
