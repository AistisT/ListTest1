using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListTest.Models
{
    public class Test
    {
        public List<DataHolder> list { get; set; }
        public string random { get; set; }
        public Test()
        {
            list = new List<DataHolder>();
            System.Diagnostics.Debug.WriteLine("called constructor in Class");


        }


        public void printValues()
        {
            foreach (DataHolder holder in list)
            {
                System.Diagnostics.Debug.WriteLine(holder.id + " " + holder.value);
            }
            System.Diagnostics.Debug.WriteLine(random);
        }
    }
}