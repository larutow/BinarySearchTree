using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(10);
            tree.Add(50);
            tree.Add(5);
            tree.Add(8);
            tree.Add(25);
            tree.Add(100);
            tree.Add(3);


            bool find5 = tree.Search(5);
            bool find25 = tree.Search(25);
            bool find42 = tree.Search(42);
            Console.WriteLine(find5);
            Console.WriteLine(find25);
            Console.WriteLine(find42);
            Console.ReadLine();
        }
    }
}
