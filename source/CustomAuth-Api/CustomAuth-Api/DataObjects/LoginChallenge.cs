using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuth_Api.DataObjects
{
    public class LoginChallenge
    {
        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
    }
}