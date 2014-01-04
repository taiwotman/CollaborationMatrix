/***
 Author: Taiwo O. Adetiloye, 2012
*****/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThesisProject
{
    public class CollaborationMatrix
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } 

        public CollaborationMatrix()
        {

        }
        public CollaborationMatrix(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0}  {1}  {2})", X, Y, Z);
        }
    }
}
