#pragma checksum "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3c48a25a52df4e7047b278c733791b3926801b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-g1hvm280bn>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p b-g1hvm280bn>This component demonstrates fetching data from the server.</p>");
#nullable restore
#line 8 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p b-g1hvm280bn><em b-g1hvm280bn>Loading...</em></p>");
#nullable restore
#line 11 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddAttribute(5, "b-g1hvm280bn");
            __builder.AddMarkupContent(6, "<thead b-g1hvm280bn><tr b-g1hvm280bn><th b-g1hvm280bn>Date</th>\r\n                <th b-g1hvm280bn>Temp. (C)</th>\r\n                <th b-g1hvm280bn>Temp. (F)</th>\r\n                <th b-g1hvm280bn>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddAttribute(8, "b-g1hvm280bn");
#nullable restore
#line 24 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.AddAttribute(10, "b-g1hvm280bn");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "b-g1hvm280bn");
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddAttribute(16, "b-g1hvm280bn");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "b-g1hvm280bn");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "b-g1hvm280bn");
            __builder.AddContent(25, 
#nullable restore
#line 30 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
