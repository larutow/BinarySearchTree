using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node rootNode;
        private Node thisNode;
        public BinarySearchTree()
        {
            rootNode = null;
            thisNode = null;
        }

        public void Add(int data)
        {
            /*          10
             * 5                    15
             *      8           12
             * 
             * If thisNode is empty, make added data this, return
             * 
             * Start from root (thisNode = rootNode)
             * while(true)
             * 
             * If data <= this node.val && thisNode.left == null
             *      thisnode.left(data)
             *      return
             * else if data > thisnode.val && thisnode.right == null
             *      thisnode.right(data)
             *      return
             * else if data <= thisnode.val && thisnote.left != null{
             *      thisnode = thisnode.left
             * else if data > thisnode && thisnode.right != null{
             *      this node = thisnode.right
             * }
             * 
             * cases:
             *  Case 1 - data value to add is less than or equal to this node & empty spot left
             *      Add it left, return / break
             *  Case 2- data value to add is less than or equal to this node & empty spot right
             *      Add it right, return / break
             *  Case 3 (like case 1) - data value to add is less than or equal to this node & left != empty spot
             *      make this node = left node, search deeper
             *  Case 4 (like case 2) data value to add is greater than this node & right != empty spot
             *      make this node = right node, search deeper
             * 
             * 
             */


            if (rootNode == null)
            {
                rootNode = new Node(data);
                
                return;
            }

            thisNode = rootNode;

            while (true)
            {
                if (data <= thisNode.val && thisNode.left == null)
                {
                    thisNode.left = new Node(data);
                    return;
                }
                else if(data > thisNode.val && thisNode.right == null)
                {
                    thisNode.right = new Node(data);
                    return;
                }
                else if(data <= thisNode.val && thisNode.left != null)
                {
                    thisNode = thisNode.left;
                }
                else if(data > thisNode.val && thisNode.right != null)
                {
                    thisNode = thisNode.right;
                }
            }
           

        }

        public bool Search(int data)
        {
            /*
             * Start at root
             * Case 1: data = this node
             *  return bool true 
             *  
             *  Case 2: data < this node && thisnode.left == null
             *  bool false 
             *  return
             *  
             *  case 3: data > this node && thisnode.right == null
             *  bool false 
             *  return
             *  
             *  case 4: data < this node & thisnode.left != null
             *  thisNode = thisnode.left
             * 
             * case 5: data > this node & this node.right != null
             *  thisNode = thisnode.right
             * 
             * 
             */

            thisNode = rootNode;
            while (true)
            {
                if(data == thisNode.val)
                {
                    return true;
                }
                if (data < thisNode.val && thisNode.left == null)
                {
                    return false;
                }
                else if (data > thisNode.val && thisNode.right == null)
                {
                    return false;
                }
                else if (data < thisNode.val && thisNode.left != null)
                {
                    thisNode = thisNode.left;
                }
                else if (data > thisNode.val && thisNode.right != null)
                {
                    thisNode = thisNode.right;
                }
            }
        }
    }
}
