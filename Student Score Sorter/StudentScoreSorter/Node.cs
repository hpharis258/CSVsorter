using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoreSorter
{
    public class Node
    {
        public string data;
        public Node nextNode;
        private string[] SplitString;
        public int score;
        // Constructor
        public Node(string data)
        {
            // Node Stores a string Data
            this.data = data;
            // 
            this.SplitString = data.Split(',');
            // Gets the Last Item, where the Score is.
            this.score = Int32.Parse(SplitString.Last());
        }   
    }
}
