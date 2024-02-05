using BinarySearchTree.Entities;
using FluentAssertions;
using Xunit;

namespace BinarySearchTree.Test.EntityTests
{
    public sealed class SearchTreeNodeTests
    {
        private SearchTreeNode _testSubject;

        [Fact]
        public void ShouldCreateANewRootNodeWithProvidedValue()
        {
            _testSubject = new SearchTreeNode(50);

            _testSubject.NodeValue.Should().Be(50);
            _testSubject.LeftNode.Should().BeNull();
            _testSubject.RightNode.Should().BeNull();
        }

        [Fact]
        public void ShouldAddALeftNodeWhenProvidedWithLowerValue()
        {
            _testSubject = new SearchTreeNode(50);
            _testSubject.AddChildNode(30);

            _testSubject.NodeValue.Should().Be(50);
            _testSubject.LeftNode.Should().NotBeNull();
            _testSubject.LeftNode.NodeValue.Should().Be(30);
            _testSubject.RightNode.Should().BeNull();
        }

        [Fact]
        public void ShouldAddARightNodeWhenProvidedWithHigherValue()
        {
            _testSubject = new SearchTreeNode(50);
            _testSubject.AddChildNode(70);

            _testSubject.NodeValue.Should().Be(50);
            _testSubject.LeftNode.Should().BeNull();
            _testSubject.RightNode.Should().NotBeNull();
            _testSubject.RightNode.NodeValue.Should().Be(70);
        }

        [Fact]
        public void ShouldAddASecondLevelToLeftNodeWhenProvidedWithAppropriateValues()
        {
            _testSubject = new SearchTreeNode(50);
            _testSubject.AddChildNode(30);
            _testSubject.AddChildNode(20);
            _testSubject.AddChildNode(40);

            _testSubject.NodeValue.Should().Be(50);

            _testSubject.LeftNode.Should().NotBeNull();
            _testSubject.LeftNode.NodeValue.Should().Be(30);

            _testSubject.RightNode.Should().BeNull();

            var leftNode = _testSubject.LeftNode;
            leftNode.LeftNode.Should().NotBeNull();
            leftNode.LeftNode.NodeValue.Should().Be(20);
            leftNode.RightNode.Should().NotBeNull();
            leftNode.RightNode.NodeValue.Should().Be(40);
        }

        [Fact]
        public void ShouldAddASecondLevelToRightNodeWhenProvidedWithAppropriateValues()
        {
            _testSubject = new SearchTreeNode(50);
            _testSubject.AddChildNode(70);
            _testSubject.AddChildNode(60);
            _testSubject.AddChildNode(80);

            _testSubject.NodeValue.Should().Be(50);

            _testSubject.LeftNode.Should().BeNull();

            _testSubject.RightNode.Should().NotBeNull();
            _testSubject.RightNode.NodeValue.Should().Be(70);

            var rightNode = _testSubject.RightNode;
            rightNode.LeftNode.Should().NotBeNull();
            rightNode.LeftNode.NodeValue.Should().Be(60);
            rightNode.RightNode.Should().NotBeNull();
            rightNode.RightNode.NodeValue.Should().Be(80);
        }
    }
}
