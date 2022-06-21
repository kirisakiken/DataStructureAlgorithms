namespace DataStructureAlgorithms.Core.BinaryTree
{
    public class Node
    {
        #region Public

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; }

        #endregion

        #region Constructors

        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, Node leftChild, Node rightChild)
        {
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }

        #endregion
    }
}