using BinarySearchTree.Entities;
using BinarySearchTree.Enums;
using System;

namespace BinarySearchTree.Utilities
{
    public static class BinarySearchTreeTraversalUtility
    {
        /// <summary>
        /// Traverses a binary search tree in one of three orders, calling the provided callback for each node
        /// </summary>
        /// <param name="rootNode">The root node of the tree</param>
        /// <param name="order">The order to traverse the tree in</param>
        /// <param name="callBack">The callback method to be called for each node</param>
        public static void Traverse(this SearchTreeNode rootNode, TraversalOrder order, Action<SearchTreeNode> callBack)
        {
            switch(order) {
                case TraversalOrder.PreOrder:
                    PreOrderHelper(rootNode, callBack);
                    break;
                case TraversalOrder.PostOrder:
                    PostOrderHelper(rootNode, callBack);
                    break;
                case TraversalOrder.InOrder:
                default:
                    InOrderHelper(rootNode, callBack);
                    break;
            }
        }

        public static void InOrderHelper(SearchTreeNode node, Action<SearchTreeNode> callBack)
        {
            if (node == null) return;

            InOrderHelper(node.LeftNode, callBack);
            callBack(node);
            InOrderHelper(node.RightNode, callBack);
        }

        public static void PostOrderHelper(SearchTreeNode node, Action<SearchTreeNode> callBack)
        {
            if (node == null) return;

            PostOrderHelper(node.LeftNode, callBack);
            PostOrderHelper(node.RightNode, callBack);
            callBack(node);
        }

        public static void PreOrderHelper(SearchTreeNode node, Action<SearchTreeNode> callBack)
        {
            if (node == null) return;

            callBack(node);
            PreOrderHelper(node.LeftNode, callBack);
            PreOrderHelper(node.RightNode, callBack);
        }
    }
}
