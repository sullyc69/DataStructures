using Gee.External.Capstone.M68K;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucures
{
    public class Trees
    {

        //B-Tree

        //Red-Black Tree

        //Cartesian Tree

        //Splay Tree

        //AVL Tree

        //KD Tree


        //Trie




    }

    public class  CharTrie
    {
        private class Node
        {
            public bool isTerminal { get; set; }
            public Dictionary<char, Node> children { get; private set; }
            public Node parentNode { get; private set; }
            public char content { get; private set; }

        }

        //--Insert Word--
       


                //Char-ify and insert. check to see if char exists in chlidren. if not, isert. if end of word, add terminal true final node
               
           
    //--Search--

    //--Delete Word--

    //--Persist Trie--


  public CharTrie() { }
    
    
    }
}
