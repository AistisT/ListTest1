using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListTest.Models
{
    public class DataHolder
    {
        public int id { get; set; }
        public string value { get; set; }

        public DataHolder(int id, string value)
        {
            this.id = id;
            this.value = value;
        }
    }
}