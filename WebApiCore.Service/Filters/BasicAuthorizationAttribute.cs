using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using WebApiCore.BL.Models;
using WebApiCore.BL.Services;


namespace WebApiCore.Service.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;

    /// <summary>
    /// Provides details for basic authorization filter
    /// </summary>
    //public class BasicAuthorizationAttribute : IAuthorizationFilter
    //{
        //private ICollection<string> roleList = new List<string>();

        ///// <summary>
        ///// Instance of UserService class
        ///// </summary>
        //private UserService userService = new UserService();

        ///// <summary>
        ///// Initializes a new instance of BasicAuthorizationAttribute
        ///// </summary>
        ///// <param name="roles">Roles for basic authorization</param>
        //public BasicAuthorizationAttribute(params string[] roles)
        //{
        //    foreach (var role in roles)
        //    {
        //        this.roleList.Add(role);
        //    }
        //}

        ///// <summary>
        ///// Method calls when a process requests authorization.
        ///// </summary>
        ///// <param name="actionContext">Contains information about input action</param>
        //public override async void OnAuthorization(AuthorizationFilterContext actionContext)
        //{
        //    if (actionContext.HttpContext.Request.Headers == null)
        //    {
        //        actionContext.HttpContext.Response = actionContext.HttpContext
        //                                 .Request(HttpStatusCode.Unauthorized);
        //    }
        //    else
        //    {
        //        string authenticationString = actionContext.Request.Headers.Authorization.Parameter;
        //        string userName = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));
        //        string userNameAfterConvert = userName.Replace(":", string.Empty);

        //        UserDto user = await this.userService.GetUserByUserName(userNameAfterConvert);

        //        if (user == null)
        //        {
        //            actionContext.Response = actionContext
        //                                     .Request
        //                                     .CreateResponse(HttpStatusCode.Unauthorized);
        //        }
        //        else if (!this.roleList.Contains(user.Role))
        //        {
        //            actionContext.Response = actionContext
        //                                     .Request
        //                                     .CreateResponse(HttpStatusCode.Forbidden);
        //        }
        //    }
        //}
    //}
}
