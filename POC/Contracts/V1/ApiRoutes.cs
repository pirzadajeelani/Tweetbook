﻿ 
namespace POC.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root+"/"+Version;

        public static class Posts
        {
            public const string GetAll =Base+"/posts";
            public const string Get = Base+"/posts/{postId}";
            public const string Update = Base+"/posts/{postId}";
            public const string Delete = Base+"/posts/{postId}";
            public const string Create = Base+"/posts";
            
        }

        public class Identity {
            public const string Login = Base + "/Identity/login";
            public const string Register = Base + "/Identity/register";
            public const string Refresh = Base + "/Identity/refresh";
        }
    }
}
