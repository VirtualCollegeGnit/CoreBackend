using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace core.api.Controllers
{
    public abstract class AuthController : ControllerBase
    {

        public bool VerifyUserHasScope(params string[] acceptedScopes)
        {
            if (acceptedScopes == null)
            {
                throw new ArgumentNullException(nameof(acceptedScopes));
            }
            var scopeClaim = User?.Claims.Where(x=>x.Type=="scope" && acceptedScopes.Contains(x.Value));
            return scopeClaim.Count() == acceptedScopes.Length;
        }
    }
}
