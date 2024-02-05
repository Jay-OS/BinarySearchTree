using BinarySearchTree.Entities;
using BinarySearchTree.Enums;
using System;
using System.Collections.Generic;

namespace BinarySearchTree.Utilities.BinarySearchTreeBalancer
{
    public static class BinarySearchTreeBalancedTreeUtility
    {
        /// <summary>
        /// Returns a balanced version of the tree with minimum possible depth
        /// </summary>
        /// <param name="rootNode">The root node to be balanced</param>
        /// <returns>A balanced copy of the original binary search tree</returns>
        public static SearchTreeNode GetBalancedTree(this SearchTreeNode rootNode)
        {
            return BalancedTreeHelper(rootNode);
        }

        private static SearchTreeNode BalancedTreeHelper(SearchTreeNode node)
        {
            if (node == null) return node;

            var values = new List<int>();
            node.Traverse(TraversalOrder.InOrder, nodeItem => { values.Add(nodeItem.NodeValue); });

            var balencer = new BinarySearchTreeValueBalancer();
            var balancedValues = balencer.BalanceValues(values.ToArray());

            SearchTreeNode newRoot = null;

            Array.ForEach(balancedValues, value => {
                if (newRoot == null)
                {
                    newRoot = new SearchTreeNode(value);
                    return;
                }

                newRoot.AddChildNode(value);
            });

            return newRoot;
        }
    }
}
