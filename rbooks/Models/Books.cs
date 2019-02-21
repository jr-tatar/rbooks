using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rbooks.Models
{
    public class Books
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public ReadState ReadState { get; set; }
        public byte ReadStateId { get; set; }
    }
}