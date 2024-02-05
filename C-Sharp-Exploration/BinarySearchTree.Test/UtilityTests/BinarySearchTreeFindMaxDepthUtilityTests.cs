using BinarySearchTree.Entities;
using BinarySearchTree.Utilities;
using BinarySearchTree.Test.UtilityTests.Helpers;
using Xunit;
using FluentAssertions;

namespace BinarySearchTree.Test.UtilityTests
{
    public class BinarySearchTreeFindMaxDepthUtilityTests
    {
        private readonly SearchTreeNode _testSubject;

        public BinarySearchTreeFindMaxDepthUtilityTests()
        {
            var treeBuilder = new BinarySearchTreeBuilder();
            _testSubject = treeBuilder.Build();
        }

        [Fact]
        public void FindsTheCorrectMaxDepthForTheTree()
        {
            var maxDepth = _testSubject.MaxDepth();
            maxDepth.Should().Be(4);
        }
    }
}
