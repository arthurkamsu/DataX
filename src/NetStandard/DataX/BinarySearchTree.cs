using System;

namespace DataX
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public int Count { get; set; }

        public bool AcceptDuplicates { get; set; }

        private BinarySearchTreeNode Root { get; set; }

        public BinarySearchTree() { Root = null; Count = 0; }

        public BinarySearchTree(T rootData) { Root = new BinarySearchTreeNode(rootData); Count = 1; }


        public bool Insert(T dataToInsert)
        {            
            if (Root == null)
            {
                Root = new BinarySearchTreeNode(dataToInsert);
                Count++;
                return true;
            }
            else
            {
                if (Root.Insert(dataToInsert, AcceptDuplicates))
                {
                    Count++;
                    return true;
                }
                else return false;//send a message to the developer to tell him why
            } 
        }
        public string Print()
        {
            if (Root == null)                           
                return "";
            else
            {
                var result = Root.Print();
                Console.Write(result);
                return result;
            }
                
        }






        private class BinarySearchTreeNode
        {
            public T Data { get; set; }
            private BinarySearchTreeNode Left { get; set; }
            private BinarySearchTreeNode Right { get; set; }

            /*public BinarySearchTreeNode(T data, BinarySearchTreeNode<T> left = null, BinarySearchTreeNode<T> right = null)
            {
                Data = data;
                Left = left;
                Right = right;
                //We have to check if the node is BST Node
            }*/
            public BinarySearchTreeNode(T data)
            {
                Data = data;
                Left = Right = null;
            }

            public bool IsLeaf { get { return (Left == null && Right == null); } }

            public bool Insert(T DataToInsert, bool AcceptDuplicates)
            {

                if (Data.CompareTo(DataToInsert) == 0 && !AcceptDuplicates) return false;
                else if (Data.CompareTo(DataToInsert) == 0 && AcceptDuplicates)
                {
                    if (Left == null)
                    {
                        Left = new BinarySearchTreeNode(DataToInsert);
                        return true;
                    }
                    else
                        return Left.Insert(DataToInsert, AcceptDuplicates);
                }
                else if (Data.CompareTo(DataToInsert) > 0)
                {
                    if (Left == null)
                    {
                        Left = new BinarySearchTreeNode(DataToInsert);
                        return true;
                    }
                    else
                        return Left.Insert(DataToInsert, AcceptDuplicates);
                }
                else if (Data.CompareTo(DataToInsert) < 0)
                {
                    if (Right == null)
                    {
                        Right = new BinarySearchTreeNode(DataToInsert);
                        return true;
                    }
                    else
                        return Right.Insert(DataToInsert, AcceptDuplicates);
                }
                return false;
            }


            public string Print()
            {
                if (this == null || Data == null)
                    return "";
                var sb = new System.Text.StringBuilder();

                if (Left != null) sb.Append(Left.Print() + " ");
                sb.Append(Data.ToString());
                if (Right != null) sb.Append(" " + Right.Print());

                return sb.ToString();
            }

        }


    }
}
