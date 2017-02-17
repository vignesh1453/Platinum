using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HacakathonApi.Models
{
    public class BuildsCount
    {
        public string Date { get; set; }
        public int Success { get; set; }
        public int Failed { get; set; }
    }
}