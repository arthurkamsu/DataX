using System;

namespace DataX
{
    public class BinarySearchTreeNode<T> where T : IComparable<T>
    {        
        public T Data { get; set; }
        private BinarySearchTreeNode<T> Left { get; set; }
        private BinarySearchTreeNode<T> Right { get; set; }

        public BinarySearchTreeNode(T data, BinarySearchTreeNode<T> left = null, BinarySearchTreeNode<T> right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public BinarySearchTreeNode(T data)
        {
            Left = Right = null;
        }

        public bool IsLeaf { get { return (Left == null && Right == null); } }

        public bool Insert(T DataToInsert)
        {
            if (Data.CompareTo(DataToInsert) == 0)
                return false;
            else if (Data.CompareTo(DataToInsert) < 0)
            {
                if (Left == null)
                {
                    Left = new BinarySearchTreeNode<T>(DataToInsert);
                    return true;
                }
                else
                    return Left.Insert(DataToInsert);
            }
            else if (Data.CompareTo(DataToInsert) > 0)
            {
                if (Right == null)
                {
                    Right = new BinarySearchTreeNode<T>(DataToInsert);
                    return true;
                }
                else
                    return Right.Insert(DataToInsert);
            }
            return false;
        }

        
        public void Print()
        {
            if (this == null || Data==null)
                return;

            if (Left != null) Left.Print();            
            Console.Write(" " + Data.ToString());
            if (Right != null)  Right.Print();
        }
        
    }
}
