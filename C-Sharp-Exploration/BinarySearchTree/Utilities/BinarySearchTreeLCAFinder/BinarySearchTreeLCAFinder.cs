using BinarySearchTree.Entities;

namespace BinarySearchTree.Utilities.BinarySearchTreeLCAFinder
{
    internal sealed class BinarySearchTreeLCAFinder
    {
        private SearchTreeNode _rootNode;
        private SearchTreeNode _searchNodeOne;
        private SearchTreeNode _searchNodeTwo;

        private SearchTreeNode _lowestCommonAncestor;

        /// <summary>
        /// Creates an instance of <see cref="BinarySearchTreeLCAFinder"/> used to find the lowest
        /// common ancestor for two specific nodes
        /// </summary>
        /// <param name="rootNode">The root node of the binary search tree</param>
        /// <param name="searchNodeOne">The first node to search for</param>
        /// <param name="searchNodeTwo">The second node to search for</param>
        public BinarySearchTreeLCAFinder(SearchTreeNode rootNode, SearchTreeNode searchNodeOne, SearchTreeNode searchNodeTwo)
        {
            _rootNode = rootNode;
            _searchNodeOne = searchNodeOne;
            _searchNodeTwo = searchNodeTwo;
        }

        /// <summary>
        /// Finds the lowest common ancestor in the provided binary search tree for the two nodes provided in the constructor
        /// </summary>
        /// <returns>Lowest common ancestor node</returns>
        public SearchTreeNode Find()
        {
            IsCommonPath(_rootNode);
            return _lowestCommonAncestor;
        }

        /*
         * Verifies whether either search node can be found in either the left or right subtree
         * Verifies whather the provided node is either of the search nodes
         * LCA has been found if:
         * 1. One of the search nodes can be found in either the left or right subtree AND the provided node is one of the search nodes
         * 2. Each of the search nodes can be found in opposite subtrees
         */
        private bool IsCommonPath(SearchTreeNode node)
        {
            if (node == null) return false;

            var isLeft = IsCommonPath(node.LeftNode);
            var isRight = IsCommonPath(node.RightNode);
            var isMid = node == _searchNodeOne || node == _searchNodeTwo;

            if ((isMid && isLeft) || (isMid && isRight) || (isLeft && isRight))
            {
                _lowestCommonAncestor = node;
            }

            return isLeft || isRight || isMid;
        }
    }
}
