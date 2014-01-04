/***
 Author: Taiwo O. Adetiloye, 2012
*****/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThesisProject
{
    public class TestCase
    {
        public Entity Business11 { get; set; }
        public Entity Customer12 { get; set; }
        public Entity Customer21 { get; set; }
        public Entity Customer22 { get; set; }

        public CollaborationMatrix MatrixSN { get; set; }
        public CollaborationMatrix MatrixCC { get; set; }

        public Weight TestCaseWeightSN { get; set; }
        public Weight TestCaseWeightCC { get; set; }

        public TestCase()
        {
            Business11 = new Entity();
            Customer12 = new Entity();
            Customer21 = new Entity();
            Customer22 = new Entity();

            MatrixSN = new CollaborationMatrix();
            MatrixCC = new CollaborationMatrix();
           
        }

        public void output()
        {
            MatrixSN = Business11 + Customer22;
            MatrixCC = Customer21 + Customer12;

            TestCaseWeightSN = new Weight("SN", MatrixSN.X + MatrixSN.Y + MatrixSN.Z);
            TestCaseWeightCC = new Weight("CC", MatrixCC.X + MatrixCC.Y + MatrixCC.Z);

        }
    }
}
