using ASP_WEB_DocumentReader.Domain.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Net;

namespace ASP_WEB_DocumentReader.Helpers
{
    public class AppRouteView : RouteView
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ILoginService LoginService { get; set; }

        protected override void Render(RenderTreeBuilder builder)
        {
            var authorize = Attribute.GetCustomAttribute(RouteData.PageType, typeof(AuthorizeAttribute)) != null;
            if (authorize && LoginService.User == null)
            {
                var returnUrl = WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery);
                NavigationManager.NavigateTo($"Login");
            }
            else
            {
                base.Render(builder);
            }
        }
    }
}
