#pragma checksum "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7795260169a30c7ed1b2f784abb9158a3e9323"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using BlazorCA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using BlazorCA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Film List</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
 if (films == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th>Title</th>
                <th>Description</th>
                <th>Director</th>
                <th>Producer</th>
                <th>Release Date</th>
                <th>Rotten Tomatoes Score</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 24 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
             foreach (var film in films)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Director

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Producer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 31 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Release_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 32 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
                     film.Rt_score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 34 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 37 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\FetchData.razor"
       
    private FilmList[] films;

    protected override async Task OnInitializedAsync()
    {
        films = await Http.GetFromJsonAsync<FilmList[]>("/films");
    }

    public class FilmList
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }

        public string Release_date { get; set; }

        public string Rt_score { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591