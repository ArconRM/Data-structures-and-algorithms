using System;
using System.Collections.Generic;

namespace DataStructAnAlgorithms.Practicum21
{
    public class BinaryTree //класс, реализующий АТД «дерево бинарного поиска»
    {
        //вложенный класс, отвечающий за узлы и операции допустимы для дерева бинарного поиска
        private class Node
        {
            public object inf; //информационное поле
            public Node left; //ссылка на левое поддерево
            public Node right; //ссылка на правое поддерево

            public Node(object nodeInf)
            {
                inf = nodeInf;
                left = null;
                right = null;
            }

            //добавляет узел в дерево так, чтобы дерево оставалось деревом бинарного поиска
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
                    }
                    else
                    {
                        Add(ref r.right, nodeInf);
                    }
                }
            }

            public static void Preorder(Node r)
            {
                //прямой обход дерева
                if (r != null)
                {
                    Console.Write("{0} ", r.inf);
                    Preorder(r.left);
                    Preorder(r.right);
                }
            }

            public static void PreorderWithDepthCount(Node r, int currentDepth)
            {
                //прямой обход дерева
                if (r != null)
                {
                    Console.Write($"{r.inf} {currentDepth}\n");
                    currentDepth++;
                    PreorderWithDepthCount(r.left, currentDepth);
                    PreorderWithDepthCount(r.right, currentDepth);
                }
            }

            public static int CountLeavesWithEvenValues(Node r)
            {
                int count = 0;
                if (r != null)
                {
                    if (r.left is null && r.right is null && (int)r.inf % 2 == 0)
                        count += 1;
                    else
                    {
                        count += CountLeavesWithEvenValues(r.left);
                        count += CountLeavesWithEvenValues(r.right);
                    }
                }
                return count;
            }

            public static void Inorder(Node r)
            {
                //симметричный обход дерева
                if (r != null)
                {
                    Inorder(r.left);
                    Console.Write("{0} ", r.inf);
                    Inorder(r.right);
                }
            }

            public static void Postorder(Node r)
            {
                //обратный обход дерева
                if (r != null)
                {
                    Postorder(r.left);
                    Postorder(r.right);
                    Console.Write("{0} ", r.inf);
                }
            }

            //поиск ключевого узла в дереве
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
                        }
                        else
                        {
                        }
                        Search(r.left, key, out item);
                        Search(r.right, key, out item);
                    }
                }
            }

            //методы Del и Delete позволяют удалить узел в дереве так, чтобы дерево при этом
            //оставалось деревом бинарного поиска
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
                    throw new Exception("Данное значение в дереве отсутствует");
                }
                if (((IComparable)t.inf).CompareTo(key) > 0)
                {
                    Delete(ref t.left, key);
                }
                else
                {
                    if (((IComparable)t.inf).CompareTo(key) < 0)
                    {
                        Delete(ref t.right, key);
                    }
                    else
                    {
                        if (t.left == null)
                            t = t.right;
                        if (t.right == null)
                            t = t.left;
                        else
                        {
                            Del(t, ref t.left);
                        }
                    }
                }
            }
        }

        Node tree; //ссылка на корень дерева

        public object Inf //свойство позволяет получить доступ к значению информационного поля корня дерева
        {
            set { tree.inf = value; }
            get { return tree.inf; }
        }

        public BinaryTree() //открытый конструктор
        {
            tree = null;
        }

        private BinaryTree(Node r) //закрытый конструктор
        {
            tree = r;
        }

        public void Add(object nodeInf) //добавление узла в дерево
        {
            Node.Add(ref tree, nodeInf);
        }

        //организация различных способов обхода дерева
        public void Preorder()
        {
            Node.Preorder(tree);
        }

        public void Inorder()
        {
            Node.Inorder(tree);
        }

        public void Postorder()
        {
            Node.Postorder(tree);
        }

        //поиск ключевого узла в дереве
        public BinaryTree Search(object key)
        {
            Node r;
            Node.Search(tree, key, out r);
            BinaryTree t = new BinaryTree(r);
            return t;
        }

        //удаление ключевого узла в дереве
        public void Delete(object key)
        {
            Node.Delete(ref tree, key);
        }

        public int CountNodesWithEvenValues() => Node.CountLeavesWithEvenValues(tree);

        public void PreorderWithDepthCount() => Node.PreorderWithDepthCount(tree, 0);
    }
}

