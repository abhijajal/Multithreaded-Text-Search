/* Written by Abhishek Jajal for CS6326.001, assignment 4, starting October 11, 2019.
 * This class is used to create, a Queue which stores the results as the instances of this class.
    NetID: apj180001 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apj180001Asg4
{
    class resultSet
    {   
        public int lineNo; // line number
        public string line; // Entire line
        // Contructor
        public resultSet(int lineNo, string line)
        {
            this.lineNo = lineNo;
            this.line = line;
        }
    }
}
