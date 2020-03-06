using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cSharp_webapp.Models
{
    public class Antique
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Cost { get; set; }
    }

    //this page will probably be on /antiques/random
}