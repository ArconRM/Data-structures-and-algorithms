using System;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace DataStructAnAlgorithms.Practicum21
{
    public class BalancedBinaryTree
    {
        private class Node
        {
            public object inf; // информационное поле
            public Node left; // ссылка на левое поддерево
            public Node right; // ссылка на правое поддерево
            private int height;

            public int Height
            {
                get { return (this != null) ? height : 0; }
            }

            public int BalanceFactor
            {
                get
                {
                    int rh = (right != null) ? right.Height : 0;
                    int lh = (left != null) ? left.Height : 0;
                    return rh - lh;
                }
            }

            public void NewHeight()
            {
                int rh = (right != null) ? right.Height : 0;
                int lh = (left != null) ? left.Height : 0;
                height = ((rh > lh) ? rh : lh) + 1;
            }

            public Node(object nodeInf)
            {
                inf = nodeInf;
                left = null;
                right = null;
                height = 1;
            }

            // добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
            public static void Add(ref Node r, object nodeInf)
            {
                if (r == null)
                {
                    r = new Node(nodeInf);
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(nodeInf) > 0)
                    {
                        Add(ref r.left, nodeInf);
                        r.NewHeight();
                    }
                    else
                    {
                        Add(ref r.right, nodeInf);
                        r.NewHeight();
                    }
                }
            }

            // прямой обход дерева
            public static void Preorder(Node r)
            {
                if (r != null)
                {
                    Console.Write("{0} ({1}) ", r.inf, r.height);
                    Preorder(r.left);
                    Preorder(r.right);
                }
            }

            public static List<object> PreorderToList(Node r)
            {
                List<object> result = new List<object>();
                PreorderHelper(r, result);
                return result;
            }

            private static void PreorderHelper(Node r, List<object> result)
            {
                if (r != null)
                {
                    result.Add(r.inf);
                    PreorderHelper(r.left, result);
                    PreorderHelper(r.right, result);
                }
            }

            // симметричный обход дерева
            public static void Inorder(Node r)
            {
                if (r != null)
                {
                    Inorder(r.left);
                    Console.Write("{0} ({1}) ", r.inf, r.height);
                    Inorder(r.right);
                }
            }

            // обратный обход дерева
            public static void Postorder(Node r)
            {
                if (r != null)
                {
                    Postorder(r.left);
                    Postorder(r.right);
                    Console.Write("{0} ({1}) ", r.inf, r.height);
                }
            }

            // поиск ключевого узла в дереве
            public static void Search(Node r, object key, out Node item)
            {
                if (r == null)
                {
                    item = null;
                }
                else
                {
                    if (((IComparable)(r.inf)).CompareTo(key) == 0)
                    {
                        item = r;
                    }
                    else
                    {
                        if (((IComparable)(r.inf)).CompareTo(key) > 0)
                        {
                            Search(r.left, key, out item);
                        }
                        else
                        {
                            Search(r.right, key, out item);
                        }
                    }
                }
            }

            //методы Del и Delete позволяют удалить узел в дереве так, чтобы дерево при этом
            //оставалось АВЛ-деревом
            private static void Del(Node t, ref Node tr)
            {
                if (tr.right != null)
                {
                    Del(t, ref tr.right);
                }
                else
                {
                    t.inf = tr.inf;
                    tr = tr.left;
                }
            }

            public static void Delete(ref Node t, object key)
            {
                if (t == null)
                {
                    Console.WriteLine("Данное значение в дереве отсутствует");
                }
                else
                {
                    if (((IComparable)(t.inf)).CompareTo(key) > 0)
                    {
                        Delete(ref t.left, key);
                        t.left.NewHeight();
                    }
                    else
                    {
                        if (((IComparable)(t.inf)).CompareTo(key) < 0)
                        {
                            Delete(ref t.right, key);
                            t.right.NewHeight();
                        }
                        else
                        {
                            if (t.left == null)
                            {
                                t = t.right;
                            }
                            else
                            {
                                if (t.right == null)
                                {
                                    t = t.left;
                                }
                                else
                                {
                                    Del(t, ref t.left);
                                    t.left.NewHeight();
                                }
                            }
                            t.NewHeight();
                        }
                    }
                }
            }
        }

        Node tree; // ссылка на корень дерева

        public object Inf // свойство позволяет получить доступ к значению информационного поля корня дерева
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        public BalancedBinaryTree() // открытый конструктор
        {
            tree = null;
        }

        private BalancedBinaryTree(Node r) // закрытый конструктор
        {
            tree = r;
        }

        public void Add(object nodeInf) // добавление узла в дерево
        {
            Node.Add(ref tree, nodeInf);
        }

        public void Preorder()
        {
            Node.Preorder(tree);
        }

        public List<object> PreorderToList()
        {
            return Node.PreorderToList(tree);
        }

        public void Inorder()
        {
            Node.Inorder(tree);
        }

        public void Postorder()
        {
            Node.Postorder(tree);
        }

        // поиск ключевого узла в дереве
        public BalancedBinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BalancedBinaryTree t = new BalancedBinaryTree(r);
            return t;
        }

        // удаление ключевого узла в дереве
        public void Delete(object key)
        {
            Node.Delete(ref tree, key);
        }

        public bool CheckIfCanBeRepairedByAddingNodes(int n)
        {
            // Проходим и записываем где плохо
            Queue<Node> shitNodes = GetShitNodes(tree);

            Console.WriteLine("Список сломанных вершин:");
            foreach (var node in shitNodes)
            {
                Console.Write($"{node.inf} ");
            }
            Console.WriteLine();

            if (shitNodes.Count == 0)
            {
                Console.WriteLine("Дерево и так сбалансировано.");
                return true;
            }

            if (shitNodes.Count > n)
            {
                Console.WriteLine("Дерево не спасти.");
                return false;
            }

            List<int> addedNodes = new();

            // Идем по каждой ноде и добавляем новую туда где мало
            while (addedNodes.Count < n)
            {
                Node node = shitNodes.Dequeue();

                // Идем вправо
                if (node.BalanceFactor < -1)
                {
                    while (node.right is not null)
                    {
                        node = node.right;
                    }
                    Add((int)node.inf + 1);
                    addedNodes.Add((int)node.inf + 1);
                }
                // Идем влево
                else if (node.BalanceFactor > -1)
                {
                    while (node.left is not null)
                    {
                        node = node.left;
                    }
                    Add((int)node.inf - 1);
                    addedNodes.Add((int)node.inf - 1);
                }

                shitNodes = GetShitNodes(tree);
                if (shitNodes.Count == 0)
                {
                    Console.WriteLine("Дерево удалось починить, значения узлов:");
                    foreach (var addedNode in addedNodes)
                    {
                        Console.Write($"{addedNode} ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Итоговое дерево:");
                    Preorder();
                    return true;
                }
            }

            Console.WriteLine("Дерево починить не удалось");
            return false;
        }

        private Queue<Node> GetShitNodes(Node r)
        {
            List<Node> result = new List<Node>();
            GetShitNodesHelper(r, result);
            return new(result.OrderBy(n => -n.Height).ToList());
        }

        private void GetShitNodesHelper(Node r, List<Node> result)
        {
            if (r != null)
            {
                if (Math.Abs(r.BalanceFactor) > 1)
                {
                    result.Add(r);
                }
                GetShitNodesHelper(r.left, result);
                GetShitNodesHelper(r.right, result);
            }
        }
    }
}