#pragma checksum "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16f7bb4b476dcaac34700381241d8a1992801e0"
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
#nullable restore
#line 2 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
using BlazorApp1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
using BlazorApp1.Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
using Fluxor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Fluxor.Blazor.Web.Components.FluxorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 b-2h17c2zdwe>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "b-2h17c2zdwe");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
                                this.CounterState.Value.Step

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => this.CounterState.Value.Step = __value, this.CounterState.Value.Step, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(7, "b-2h17c2zdwe");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "b-2h17c2zdwe");
            __builder.AddContent(11, "Current count: ");
            __builder.AddContent(12, 
#nullable restore
#line 12 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
                   CounterState.Value.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-2h17c2zdwe");
            __builder.AddContent(18, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenComponent<BlazorApp1.Components.Thing>(20);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\dev\Experiments\BlazorExperiment\BlazorApp1\Pages\Counter.razor"
       
    private void IncrementCount()
    {
        Dispatcher.Dispatch(new AddCounter(CounterState.Value.Step));
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDispatcher Dispatcher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IState<CounterState> CounterState { get; set; }
    }
}
#pragma warning restore 1591
