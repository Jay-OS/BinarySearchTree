using System;
using System.Linq;
using BinarySearchTree.Entities;

namespace BinarySearchTree.Test.UtilityTests.Helpers
{
    internal sealed class BinarySearchTreeBuilder
    {
        public SearchTreeNode Build(bool balancedTree = true)
        {
            var testValues = new int[] { 100, 60, 140, 40, 80, 120, 160, 30, 50, 150, 170, 70, 90, 110, 130 };

            if (!balancedTree)
            {
                testValues = testValues.OrderByDescending(value => value).ToArray();
            }

            SearchTreeNode searchTree = null;

            Array.ForEach(testValues, value => {
                if (searchTree == null)
                {
                    searchTree = new SearchTreeNode(value);
                    return;
                }

                searchTree.AddChildNode(value);
            });

            return searchTree;
        }
    }
}
