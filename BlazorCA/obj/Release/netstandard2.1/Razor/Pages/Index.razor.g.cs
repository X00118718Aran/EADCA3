#pragma checksum "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54a7cff7b62bc72ec56f22146269ac2fd22ebb90"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCA.Pages
{
    #line hidden
    using System;
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
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using BlazorCA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\_Imports.razor"
using BlazorCA.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center text-primary\">A Blazor website using the Studio Ghibli Api</h1>\n\n");
#nullable restore
#line 6 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
 if (characters == null || films == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 9 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-4");
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.AddMarkupContent(15, "<thead>\n                    <tr>\n                        <th>Name</th>\n                        <th>Gender</th>\n                        <th>Age</th>\n                    </tr>\n                </thead>\n                ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 24 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                     foreach (var character in randChars)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                        ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\n                            ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "bio/{" + (
#nullable restore
#line 27 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                               character.Id

#line default
#line hidden
#nullable disable
            ) + "}");
            __builder.AddContent(24, 
#nullable restore
#line 27 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                                               character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 28 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                 character.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                            ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 29 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                 character.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n");
#nullable restore
#line 31 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-4");
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "table");
            __builder.AddAttribute(41, "class", "table");
            __builder.AddMarkupContent(42, "\n                ");
            __builder.AddMarkupContent(43, "<thead>\n                    <tr>\n                        <th>Title</th>\n                        <th>Release Date</th>\n                        <th>Review Score</th>\n                    </tr>\n                </thead>\n                ");
            __builder.OpenElement(44, "tbody");
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 45 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                     foreach (var film in randFilms)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                        ");
            __builder.OpenElement(47, "tr");
            __builder.AddMarkupContent(48, "\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 48 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                 film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n                            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 49 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                 film.Release_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 50 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                                 film.Rt_score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n");
#nullable restore
#line 52 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\n");
#nullable restore
#line 58 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Aran\source\repos\BlazorCA\BlazorCA\Pages\Index.razor"
      
    private List<CharacterList> characters = new List<CharacterList>();
    private List<FilmList> films = new List<FilmList>();
    private List<CharacterList> randChars = new List<CharacterList>();
    private List<FilmList> randFilms = new List<FilmList>();
    Random r = new Random();

    void RandLists()
    {
        randChars.Clear();
        randFilms.Clear();
        int rInt;
        while (randChars.Count < 5 && randFilms.Count < 5)
        {
            rInt = r.Next(0, (characters.Count - 1));
            randChars.Add(characters.ElementAt(rInt));
            rInt = r.Next(0, (films.Count - 1));
            randFilms.Add(films.ElementAt(rInt));
        }
    }

    protected override async Task OnInitializedAsync()
    {
        characters = await Http.GetFromJsonAsync<List<CharacterList>>("/people");
        films = await Http.GetFromJsonAsync<List<FilmList>>("/films");
        RandLists();
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
    public class CharacterList
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Eye_color { get; set; }

        public string Hair_color { get; set; }

        public string[] Films { get; set; }

        public string Species { get; set; }

        public string Url { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
