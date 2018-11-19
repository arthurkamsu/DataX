using System;
using Xunit;
using DataX;
namespace XUnitTestDataX
{
    public class TestBinarySearchTreeNode
    {
        [Fact]
        public void TestPrintTree()
        {
            /*create the BST*/
            //BinarySearchTree<int> tree = new BinarySearchTree<int>();
            /*create root*/
            //tree.Root = new BinarySearchTreeNode<int>(1);
            //tree.Insert(1);
            /* following is the tree after above statement 
                  1 
                /   \ 
              null  null     */

            //tree.Root.Left = new BinarySearchTreeNode<int>(2);
            //tree.Insert(2);
            //tree.Root.Right = new BinarySearchTreeNode<int>(3);
            //tree.Insert(3);

            /* 2 and 3 become left and right children of 1 
                   1 
                 /   \ 
                2      3 
              /    \    /  \ 
            null null null null  */

            //tree.Root.Left.Left = new BinarySearchTreeNode<int>(4);
            //tree.Insert(4);
            /* 4 becomes left child of 2 
                        1 
                    /       \ 
                   2          3 
                 /   \       /  \ 
                4    null  null  null 
               /   \ 
              null null 
             */


            //Assert.Equal("1 2 3 4",tree.Print());

            //new test with random numbers
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
          
            
            tree.Insert(18);
            tree.Insert(-4);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(5);

            Assert.Equal("-4 2 3 5 18", tree.Print());

        }

        [Fact]
        public void TestCounyTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            
            tree.Insert(18);
            tree.Insert(-4);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(5);

            Assert.Equal(5, tree.Count);
        }
    }
}
