using BinarySearchTree.Entities;
using BinarySearchTree.Utilities;
using BinarySearchTree.Utilities.BinarySearchTreeBalancer;
using BinarySearchTree.Test.UtilityTests.Helpers;
using Xunit;
using FluentAssertions;
using BinarySearchTree.Enums;

namespace BinarySearchTree.Test.UtilityTests
{
    public class BinarySearchTreeBalancedTreeUtilityTests
    {
        private readonly SearchTreeNode _testSubject;

        public BinarySearchTreeBalancedTreeUtilityTests()
        {
            var treeBuilder = new BinarySearchTreeBuilder();
            _testSubject = treeBuilder.Build(false);
        }

        [Fact]
        public void ShouldBalanceTree()
        {
            var balancedTree = _testSubject.GetBalancedTree();

            _testSubject.MaxDepth().Should().Be(15);
            balancedTree.MaxDepth().Should().Be(4);
        }

        [Fact]
        public void BalancedTreeShouldContainTheSameNumberOfNodesAsOriginal()
        {
            var balancedTree = _testSubject.GetBalancedTree();

            var orginalTreeNodeCount = 0;
            var balancedTreeNodeCount = 0;

            _testSubject.Traverse(TraversalOrder.InOrder, node => { orginalTreeNodeCount++; });
            balancedTree.Traverse(TraversalOrder.InOrder, node => { balancedTreeNodeCount++; });

            orginalTreeNodeCount.Should().BeGreaterThan(0);
            orginalTreeNodeCount.Should().Be(balancedTreeNodeCount);
        }
    }
}
