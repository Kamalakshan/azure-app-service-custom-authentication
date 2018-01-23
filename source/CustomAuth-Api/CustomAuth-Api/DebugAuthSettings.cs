using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuth_Api
{
    public static class DebugAuthSettings
    {
        public static string SigningKey { get; } = "GfYVqdtZUJQfghRiaonAeRQRDjytRi47";

        public static string ValidAudiences { get; } = "http://localhost";

        public static string ValidIssuers { get; } = "http://localhost";
    }
}