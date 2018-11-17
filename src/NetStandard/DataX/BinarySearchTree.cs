using System;

namespace DataX
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public int Count { get; set; }

        public bool AcceptDuplicates { get; set; }

        private BinarySearchTreeNode<T> Root { get; set; }

        public BinarySearchTree() { Root = null; Count = 0; }

        public BinarySearchTree(T rootData) { Root = new BinarySearchTreeNode<T>(rootData); Count = 1; }


        public bool Insert(T dataToInsert)
        {            
            if (Root == null)
            {
                Root = new BinarySearchTreeNode<T>(dataToInsert);
                return true;
            }
            else
                return Root.Insert(dataToInsert,AcceptDuplicates);
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




    }
}
