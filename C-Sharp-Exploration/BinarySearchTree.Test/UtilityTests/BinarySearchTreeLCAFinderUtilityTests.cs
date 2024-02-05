using BinarySearchTree.Entities;
using BinarySearchTree.Utilities;
using BinarySearchTree.Test.UtilityTests.Helpers;
using BinarySearchTree.Utilities.BinarySearchTreeLCAFinder;
using Xunit;
using FluentAssertions;

namespace BinarySearchTree.Test.UtilityTests
{
    public sealed class BinarySearchTreeLCAFinderUtilityTests
    {
        private readonly SearchTreeNode _testSubject;

        public BinarySearchTreeLCAFinderUtilityTests()
        {
            var treeBuilder = new BinarySearchTreeBuilder();
            _testSubject = treeBuilder.Build();
        }

        [Fact]
        public void SearchNodesBothTwoLevelsFromRootOnLeftBranch_TestOne()
        {
            var searchNodeOne = _testSubject.Search(30);
            var searchNodeTwo = _testSubject.Search(50);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(40);
        }

        [Fact]
        public void SearchNodesBothTwoLevelsFromRootOnLeftBranch_TestTwo()
        {
            var searchNodeOne = _testSubject.Search(30);
            var searchNodeTwo = _testSubject.Search(90);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(60);
        }

        [Fact]
        public void SearchNodesBothTwoLevelsFromRootOnRightBranch_TestOne()
        {
            var searchNodeOne = _testSubject.Search(150);
            var searchNodeTwo = _testSubject.Search(170);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(160);
        }

        [Fact]
        public void SearchNodesBothTwoLevelsFromRootOnRightBranch_TestTwo()
        {
            var searchNodeOne = _testSubject.Search(110);
            var searchNodeTwo = _testSubject.Search(170);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(140);
        }

        [Fact]
        public void SearchNodesBothAtMaxDepth()
        {
            var searchNodeOne = _testSubject.Search(30);
            var searchNodeTwo = _testSubject.Search(170);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(100);
        }

        [Fact]
        public void OneSearchNodeIsTheLowestCommonAncestor_TestOne()
        {
            var searchNodeOne = _testSubject.Search(60);
            var searchNodeTwo = _testSubject.Search(80);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(60);
        }

        [Fact]
        public void OneSearchNodeIsTheLowestCommonAncestor_TestTwo()
        {
            var searchNodeOne = _testSubject.Search(140);
            var searchNodeTwo = _testSubject.Search(160);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(140);
        }

        [Fact]
        public void OneSearchNodeIsTheLowestCommonAncestor_TestThree()
        {
            var searchNodeOne = _testSubject.Search(140);
            var searchNodeTwo = _testSubject.Search(170);

            var lowestCommonAncestor = _testSubject.FindLCA(searchNodeOne, searchNodeTwo);

            lowestCommonAncestor.NodeValue.Should().Be(140);
        }
    }
}
