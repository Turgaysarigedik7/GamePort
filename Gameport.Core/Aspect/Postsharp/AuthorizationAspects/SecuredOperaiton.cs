using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PostSharp.Aspects;

namespace Gameport.Core.Aspect.Postsharp.AuthorizationAspects
{
    [Serializable]
   public class SecuredOperaiton: OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorized = true;
                }
            }

            if (isAuthorized == false)
            {
                throw new SecurityException("You are not authorized!");
              
                ///HttpContext.Current.Response.Redirect("~/Account/SingUp");
            }

        }
       
    }
}


