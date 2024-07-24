using BlazorMyToolsMag33.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;
using System.Net;

namespace BlazorMyToolsMag33.Helpers
{
    public class AppRouteView : RouteView
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        protected override void Render(RenderTreeBuilder builder)
        {
            var authorize = Attribute.GetCustomAttribute(RouteData.PageType, typeof(AuthorizeAttribute)) != null;
            if (authorize && AuthenticationService.Admin == null)
            {
                //var returnUrl = WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery);
                //NavigationManager.NavigateTo($"login?returnUrl={returnUrl}");
                NavigationManager.NavigateTo("login");
            }
            else
            {
                base.Render(builder);
            }
        }
    }
}
