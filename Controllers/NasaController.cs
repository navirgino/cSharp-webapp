using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using cSharp_webapp.Models
using System.Web.Http;

namespace cSharp_webapp.Controllers
{
    public class NasaController : ApiController
    {
        public string GetNasaPics(string JSONString)
        {
            var seriptSerialization = new System.Web.Script
                .Serialization.JavaScriptSerializer();
            NasaPicture np = seriptSerialization
                 .Deserialize<NasaPicture>(JSONString);
            return "title - " + np.npDetails.title +
                "description - " + np.npDetails.description;
        }


    }
}
