﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class Node
    {
        public string data { get; set; }
        public Node next { get; set; }
        public Node previous { get; set; }

        public Node(string data)
        {
            this.data = data;
        }
    }
}
