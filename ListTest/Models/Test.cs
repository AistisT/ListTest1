using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListTest.Models
{
    public class Test
    {
        public List<DataHolder> list;
        public Test()
        {
            list = new List<DataHolder>();
            list.Add(new DataHolder(1, "hello1"));
            list.Add(new DataHolder(2, "hello2"));
            list.Add(new DataHolder(3, "hello3"));
            list.Add(new DataHolder(4, "hello4"));
            list.Add(new DataHolder(5, "hello4"));
        }


        public void printValues()
        {
            foreach (DataHolder holder in list)
            {
                System.Diagnostics.Debug.WriteLine(holder.id + " " + holder.value);
            }
        }
    }
}