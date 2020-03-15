using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cSharp_webapp.Models
{
    public class NasaPicture
    {
      
        public NasaPictureDetails npDetails { get; set; }
      
    }
    public class NasaPictureDetails
    {
        public string title { get; set; }
        public string location { get; set; }
        public string date_created { get; set; }
        public string description { get; set; }

    }
}