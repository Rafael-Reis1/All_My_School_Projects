using System;

public class NodeAbb
{
    public int Value;
    public NodeAbb Left;
    public NodeAbb Right;

    public NodeAbb(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    private NodeAbb root;

    public BinarySearchTree()
    {
        root = null;
    }

    public void Insert(int value)
    {
        root = InsertRec(root, value);
    }

    private NodeAbb InsertRec(NodeAbb root, int value)
    {
        if (root == null)
        {
            root = new NodeAbb(value);
            return root;
        }

        if (value < root.Value)
            root.Left = InsertRec(root.Left, value);
        else if (value > root.Value)
            root.Right = InsertRec(root.Right, value);

        return root;
    }

    public void InOrderTraversal()
    {
        InOrderRec(root);
        Console.WriteLine();
    }

    private void InOrderRec(NodeAbb root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Value + " ");
            InOrderRec(root.Right);
        }
    }

    public void PrintTree()
    {
        if (root == null)
        {
            Console.WriteLine("A árvore está vazia");
            return;
        }

        PrintTreeRec(root, 0);
    }

    private void PrintTreeRec(NodeAbb root, int space)
    {
        int COUNT = 10; // Define a distância entre os níveis
        if (root == null)
            return;

        space += COUNT;

        PrintTreeRec(root.Right, space);

        Console.WriteLine();
        for (int i = COUNT; i < space; i++)
            Console.Write(" ");
        Console.WriteLine(root.Value);

        PrintTreeRec(root.Left, space);
    }

    public bool Find(int value)
    {
        NodeAbb current = root;
        while (current != null)
        {
            if (value < current.Value)
            {
                current = current.Left;
            }
            else if (value > current.Value)
            {
                current = current.Right;
            }
            else
            {
                return true; // Valor encontrado
            }
        }
        return false; // Valor não encontrado
    }


    public void Delete(int value)
    {
        root = DeleteRec(root, value);
    }

    private NodeAbb DeleteRec(NodeAbb root, int value)
    {
        if (root == null) return root;

        // Procurando o valor
        if (value < root.Value)
            root.Left = DeleteRec(root.Left, value);
        else if (value > root.Value)
            root.Right = DeleteRec(root.Right, value);
        else
        {
            // Nó com apenas um filho ou sem filhos
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Nó com dois filhos: Pegue o sucessor em ordem (menor na subárvore direita)
            root.Value = MinValue(root.Right);

            // Delete o sucessor
            root.Right = DeleteRec(root.Right, root.Value);
        }

        return root;
    }

    private int MinValue(NodeAbb root)
    {
        int minValue = root.Value;
        while (root.Left != null)
        {
            minValue = root.Left.Value;
            root = root.Left;
        }
        return minValue;
    }

    private int Height(NodeAbb root)
    {
        if (root == null) return -1; // Base para nó nulo
        return 1 + Math.Max(Height(root.Left), Height(root.Right));
    }

    public int BalanceFactor()
    {
        return BalanceFactor(root);
    }

    private int BalanceFactor(NodeAbb root)
    {
        if (root == null) return 0; // Um nó nulo é considerado balanceado
        return Height(root.Left) - Height(root.Right);
    }
}