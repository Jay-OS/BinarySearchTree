using BinarySearchTree.Entities;

namespace BinarySearchTree.Utilities
{
    public static class BinarySearchTreeIsValidUtility
    {
        /// <summary>
        /// Checks whether a binary search tree is valid
        /// </summary>
        /// <param name="rootNode">The root node of the tree, <see cref="SearchTreeNode"/></param>
        /// <param name="minValue">The minimum value allowed to be represented by a node in the tree</param>
        /// <param name="maxValue">The maximum value allowed to be represented by a node in the tree</param>
        /// <returns>Boolean indicating whether the tree is valid</returns>
        public static bool IsValid(this SearchTreeNode rootNode, int minValue, int maxValue)
        {
            return IsValidHelper(rootNode, minValue, maxValue);
        }

        private static bool IsValidHelper(SearchTreeNode node, int minValue, int maxValue)
        {
            if (node == null) return true;
            if (node.NodeValue <= minValue || node.NodeValue >= maxValue) return false;
            return IsValidHelper(node.LeftNode, minValue, node.NodeValue) && IsValidHelper(node.RightNode, node.NodeValue, maxValue);
        }
    }
}
