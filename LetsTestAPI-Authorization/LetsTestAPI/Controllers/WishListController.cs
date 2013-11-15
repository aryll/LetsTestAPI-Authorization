using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LetsTestAPI.Controllers
{
    public class WishListController : ApiController
    {
        public IList<string> Get()
        {
            if (!User.IsInRole("Administrators")) 
                throw new HttpResponseException(new HttpResponseMessage() { StatusCode = HttpStatusCode.Unauthorized, Content = new StringContent("Your account is not authorized to see the results") });
            
                return new List<string>() { "Atomos Ninja 2 Video Recorder", 
                                        "Funko Creature from the Black Lagoon Funko Force", 
                                        "Teva Men's Dozer III Closed Toe Sandal",
                                        "ThinkGeek: Star Trek Command Tee",
                                        "ASUS Professional Graphics Monitor" };
                    }
    }
    
}
