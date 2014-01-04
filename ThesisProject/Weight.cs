/***
 Author: Taiwo O. Adetiloye, 2012
*****/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThesisProject
{
    public class Weight
    {
        public String Item { get; set; }
        public int Value{ get; set; }

        public Weight(String item, int value)
        {
            this.Item = item;
            this.Value = value;
        }
        public override string ToString()
        {
            return String.Format("{0}({1})", Item, Value);
        }
    }
}
