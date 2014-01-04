/***
 Author: Taiwo O. Adetiloye, 2012
*****/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThesisProject
{
    public class Entity
    {
        public int S { get; set; }
        public int E { get; set; }
        public int En { get; set; }
        public float Weight { get; set; }

        public bool validate()
        {
            return ((S + E + En) == 100);
        }

        public static CollaborationMatrix operator +(Entity entity1, Entity entity2)
        {
            CollaborationMatrix matrix = new CollaborationMatrix();
            matrix.X = entity1.S + entity2.S;
            matrix.Y = entity1.E + entity2.E;
            matrix.Z = entity1.En + entity2.En;

            return matrix;
        }
    }
}
