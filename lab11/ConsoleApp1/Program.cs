using System;
using System.IO;

namespace ConsoleApp1
{
    
    public class Tree
    {
        public static int Comp(string a, string b)
        {
            int i = 0;
            while (i < a.Length && i < b.Length)
            {
                if (a[i] < b[i]) return -1;
                if (a[i] > b[i]) return 1;
                i++;
            }
            if (a.Length == b.Length) return 0;
            if (a.Length < b.Length) return -1;
            return 1;
        }

        public static int Parse(string a)
        {
            int res = 0;
            int i = 0;
            while (i < a.Length)
            {
                res = res * 10 + a[i];
                i++;
            }
            return res;
        }

        public class Node
        {
            public string name;
            public int occur;
            public Node left = null;
            public Node right = null;

            public Node(string name, int occur)
            {
                this.name = name;
                this.occur = occur;
            }
        }

        public Node root = null;

        public void Dodaj(string osoba)
        {
            if (root == null)
                root = new Node(osoba, 1);
            else 
            {
                Node temp = root;
                while (Comp(temp.name, osoba) != 0)
                {
                    if (Comp(temp.name, osoba) < 0)
                    {
                        if(temp.left == null)
                            temp.left = new Node(osoba, 0);
                        else                      
                            temp = temp.left;
                    }
                    else
                    {
                        if (temp.right == null)
                            temp.right = new Node(osoba, 0);
                        else
                            temp = temp.right;
                    }
                }
                temp.occur++;
            }
            
        }
        public void Usun(string osoba)
        {
            Node temp = root;
            while (Comp(temp.name, osoba) != 0)
            {
                if (Comp(temp.name, osoba) < 0)
                    temp = temp.left;               
                else              
                    temp = temp.right;          
            }
            temp.occur--;
        }

        public Tree Odczyt(string nazwa)
        {
            Tree tree = new Tree();
            StreamReader sr = new StreamReader(nazwa);
            string line = sr.ReadLine();
            while (line != null)
            {
                string name = line;
                line = sr.ReadLine();
                int occur = Parse(line);
                for (int i = 0; i < occur; i++)
                {
                    tree.Dodaj(name);
                }

                line = sr.ReadLine();
            }
            sr.Close();
            return tree;
        }

        void Zapisz_rec(StreamWriter sw, Tree.Node node)
        {
            if (node != null)
            {
                if (node.occur > 0)
                {
                    sw.WriteLine(node.name);
                    sw.WriteLine(node.occur);
                }
                Zapisz_rec(sw, node.left);
                Zapisz_rec(sw, node.right);
            }
        }
        public void Zapisz(string nazwa)
        {
            StreamWriter sw = new StreamWriter(nazwa);
            Zapisz_rec(sw, root);
            sw.Close();
        }
        void Wyswietl_rec(Tree.Node node)
        {
            if (node != null)
            {
                if (node.occur > 0)
                {
                    Console.WriteLine(node.name);
                    Console.WriteLine(node.occur);
                }
                Wyswietl_rec(node.left);
                Wyswietl_rec(node.right);
            }
        }
        public void Wyswietl()
        {
            Wyswietl_rec(root);
            Console.WriteLine("");
        }
    }
    class Program
    {
       

        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Dodaj("cccc");
            tree.Dodaj("aaaa");
            tree.Dodaj("aaaa");
            tree.Dodaj("aaaa");
            tree.Dodaj("bbbb");
            tree.Dodaj("cccc");
            tree.Dodaj("cccc");
            tree.Wyswietl();
            tree.Usun("bbbb");
            tree.Wyswietl();
            tree.Usun("aaaa");
            tree.Wyswietl();
            tree.Zapisz("plik.txt");
            tree.Odczyt("plik.txt");
            tree.Wyswietl();
        }
    }
}
