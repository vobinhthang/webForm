using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webStore.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Thumbnail { get; set; }
    }
}