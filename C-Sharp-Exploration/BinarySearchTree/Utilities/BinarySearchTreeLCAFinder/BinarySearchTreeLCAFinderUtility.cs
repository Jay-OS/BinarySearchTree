using BinarySearchTree.Entities;

namespace BinarySearchTree.Utilities.BinarySearchTreeLCAFinder
{
    public static class BinarySearchTreeLCAFinderUtility
    {
        /// <summary>
        /// Finds the lowest common ancestor in a binary search tree for two nodes
        /// </summary>
        /// <param name="rootNode">The root node of the binary search tree</param>
        /// <param name="searchNodeOne">The first node to search for</param>
        /// <param name="searchNodeTwo">The second node to search for</param>
        /// <returns>The lowest common ancestor for the provided nodes (<see cref="SearchTreeNode"/>)</returns>
        public static SearchTreeNode FindLCA(this SearchTreeNode rootNode, SearchTreeNode searchNodeOne, SearchTreeNode searchNodeTwo)
        {
            var lcaFinder = new BinarySearchTreeLCAFinder(rootNode, searchNodeOne, searchNodeTwo);
            return lcaFinder.Find();
        }
    }
}
