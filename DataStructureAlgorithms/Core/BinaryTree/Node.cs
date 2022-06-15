namespace DataStructureAlgorithms.Core.BinaryTree
{
    public class Node
    {
        #region Public

        public Node Parent { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; }

        #endregion

        #region Constructors

        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, Node parent, Node leftChild, Node rightChild)
        {
            Value = value;
            Parent = parent;
            LeftChild = leftChild;
            RightChild = rightChild;
        }

        #endregion
    }
}