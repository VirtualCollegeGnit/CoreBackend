// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using static IdentityServer4.IdentityServerConstants;

namespace IdentityServer
{
    public static class Config
    {
        //public static IEnumerable<IdentityRole> Roles =>
        //    new IdentityRole[]
        //    {
        //        new IdentityRole("student"),
        //        new IdentityRole("administrator"),
        //        new IdentityRole("teacher")
        //    };

        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };


        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource
                {
                    Name = "basic_person",
                    DisplayName = "Basic person details",
                    Description = "Name, gender, email, phone",

                    Scopes =
                    {
                        new Scope
                        {
                            Name = "basic_person_read",
                            DisplayName = "Read access to person details"
                        },
                        new Scope
                        {
                            Name = "basic_person_write",
                            DisplayName = "Write access to person details"
                        }
                    }
                }
            };


        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // client credentials flow client
                new Client
                {
                    ClientId = "client",
                    ClientName = "Client Credentials Client",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },

                    AllowedScopes = { "api1" }
                },

                // MVC client using code flow + pkce
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",

                    AllowedGrantTypes = GrantTypes.CodeAndClientCredentials,
                    RequirePkce = true,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { "http://localhost:5003/signin-oidc" },
                    FrontChannelLogoutUri = "http://localhost:5003/signout-oidc",
                    PostLogoutRedirectUris = { "http://localhost:5003/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "api1" }
                },

                // SPA client using code flow + pkce
                new Client
                {
                    ClientId = "spa",
                    ClientName = "Core-Dev",
                    ClientUri = "http://identityserver.io",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysSendClientClaims=true,
                    AlwaysIncludeUserClaimsInIdToken=true,

                    RedirectUris =
                    {
                        "http://localhost:8080/index.html",
                        "http://localhost:8080/callback.html",
                        "http://localhost:8080/silent.html",
                        "http://localhost:8080/popup.html",
                    },

                    PostLogoutRedirectUris = { "http://localhost:8080" },
                    AllowedCorsOrigins = { "http://localhost:8080" },

                    AllowedScopes = { "openid", "profile", "basic_person_read", "basic_person_write" }
                },
                // SPA client using code flow + pkce
                new Client
                {
                    ClientId = "spa-prod",
                    ClientName = "Virtual College Core",
                    ClientUri = "https://virtualcollege.now.sh",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysSendClientClaims=true,
                    AlwaysIncludeUserClaimsInIdToken=true,

                    RedirectUris =
                    {
                        "https://virtualcollege.now.sh/index.html",
                        "https://virtualcollege.now.sh/callback.html",
                        "https://virtualcollege.now.sh/silent.html",
                        "https://virtualcollege.now.sh/popup.html",
                    },

                    PostLogoutRedirectUris = { "https://virtualcollege.now.sh" },
                    AllowedCorsOrigins = { "https://virtualcollege.now.sh" },

                    AllowedScopes = { "openid", "profile", "basic_person_read", "basic_person_write" }
                },

                new Client
                {
                    ClientId = "techspa",
                    ClientName = "TechClub - Dev ",
                    ClientUri = "http://identityserver.io",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysSendClientClaims=true,
                    AlwaysIncludeUserClaimsInIdToken=true,

                    RedirectUris =
                    {
                        "http://localhost:8081/index.html",
                        "http://localhost:8081/callback.html",
                        "http://localhost:8081/silent.html",
                        "http://localhost:8081/popup.html",
                    },

                    PostLogoutRedirectUris = { "http://localhost:8081" },
                    AllowedCorsOrigins = { "http://localhost:8081" },

                    AllowedScopes = { "openid", "profile", "basic_person_read" }
                },
                new Client
                {
                    ClientId = "techspa-prod",
                    ClientName = "Tech Club",
                    ClientUri = "http://identityserver.io",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,
                    AlwaysSendClientClaims=true,
                    AlwaysIncludeUserClaimsInIdToken=true,

                    RedirectUris =
                    {
                        "https://techclub.now.sh/index.html",
                        "https://techclub.now.sh/callback.html",
                        "https://techclub.now.sh/silent.html",
                        "https://techclub.now.sh/popup.html",
                    },

                    PostLogoutRedirectUris = { "https://techclub.now.sh" },
                    AllowedCorsOrigins = { "https://techclub.now.sh" },

                    AllowedScopes = { "openid", "profile", "basic_person_read" }
                },
            };
    }
}