#pragma checksum "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f12ed7beacdb9a2feca84d09b2355392f07f287"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Kidcon.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Kidcon.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/_Imports.razor"
using Kidcon.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/Pages/FetchData.razor"
using Kidcon.Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/lloydnicholson/Projects/Kidcon.Server/Kidcon.Server/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
