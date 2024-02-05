using BinarySearchTree.Entities;

namespace BinarySearchTree.Utilities
{
    public static class BinarySearchTreeMinMaxUtilities
    {
        /// <summary>
        /// Finds the node in the binary search tree that represents the highest value
        /// </summary>
        /// <param name="rootNode">The root node of the binary search tree</param>
        /// <returns>Node that represents the highest value</returns>
        public static SearchTreeNode GetNodeWithHighestValue(this SearchTreeNode rootNode)
        {
            if (rootNode == null) return rootNode;

            var maxNode = rootNode;
            while (maxNode.RightNode != null)
            {
                maxNode = maxNode.RightNode;
            }

            return maxNode;
        }

        /// <summary>
        /// Finds the node in the binary search tree that represents the lowest value
        /// </summary>
        /// <param name="rootNode">The root node of the binary search tree</param>
        /// <returns>Node that represents the lowest value</returns>
        public static SearchTreeNode GetNodeWithLowestValue(this SearchTreeNode rootNode)
        {
            if (rootNode == null) return rootNode;

            var minNode = rootNode;
            while (minNode.LeftNode != null)
            {
                minNode = minNode.LeftNode;
            }

            return minNode;
        }
    }
}
