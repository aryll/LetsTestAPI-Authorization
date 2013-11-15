using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LetsTestAPI.Models;
using System.Net;
using System.Net.Http;
using LetsTestAPI.Security;
using LetsTestAPI.Helpers;
using Newtonsoft.Json;
using System.Web.Http.ModelBinding;
using Newtonsoft.Json.Linq;

namespace LetsTestAPI.Controllers
{
    public class UsersController : ApiController
    {
        [HttpPost]
        public Status Authenticate([FromBody]JObject jsonData)
        {
            User user = jsonData.ToObject<User>();

            if (user == null)
                throw new HttpResponseException(new HttpResponseMessage() { StatusCode = HttpStatusCode.Unauthorized, Content = new StringContent("Please provide the credentials.") });

            if (IdentityStore.IsValidUser(user))
            {
                //Token token = new Token(user.UserId, Request.GetClientIP());
                Token token = new Token(user.UserId, "127.12.34.8");
                return new Status { Successeded = true, Token = token.Encrypt(), Message = "Successfully signed in." };
            }
            else
            {
                throw new HttpResponseException(new HttpResponseMessage() { StatusCode = HttpStatusCode.Unauthorized, Content = new StringContent("Invalid user name or password.") });
            }
        }
    }
}
