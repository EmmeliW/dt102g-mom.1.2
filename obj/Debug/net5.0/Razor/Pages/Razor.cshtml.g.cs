#pragma checksum "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4996d89025fb2bf41f4dbd2ae3f77c51b37f2e4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Razor), @"mvc.1.0.razor-page", @"/Pages/Razor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4996d89025fb2bf41f4dbd2ae3f77c51b37f2e4b", @"/Pages/Razor.cshtml")]
    public class Pages_Razor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
  
    ViewData["Title"] = "Razor sidan";

    // Get date and time 
    var dateTime = DateTime.Now;
    string date = DateTime.Now.ToString("dd MMMM yyyy");
    string time = DateTime.Now.ToString("hh:mm");

    // Get day of week
    string day = Convert.ToString(dateTime.DayOfWeek);

    //List with courses
    List<string> courses = new List<string>();

    courses.Add("DT057G Webbutveckling I");
    courses.Add("DT084G Introduktion till programmering med JavaScript");
    courses.Add("DT163G Digital bildbehandling för webb");
    courses.Add("GD008G Typografi och form för webb");
    courses.Add("DT003G Databaser");
    courses.Add("DT093G Webbutveckling II");
    courses.Add("DT068G Webbanvändbarhet");
    courses.Add("DT152G Webbdesign för CMS");
    courses.Add("DT173G Webbutveckling III");
    courses.Add("IK060G Projektledning");
    courses.Add("DT162G JavaScript-baserad webbutveckling");
    courses.Add("DT071G Programmering I C#.net");     

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Razor</h1>\r\n<h3>Information</h3>\r\n<p>Dagens datum är: ");
#nullable restore
#line 33 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
               Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Klockan är nu: ");
#nullable restore
#line 34 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
             Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
 if(day == "Monday") {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Idag är det måndag.</p>\r\n");
#nullable restore
#line 38 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Idag är det inte måndag.</p>\r\n");
#nullable restore
#line 40 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Dessa kurser har jag läst:</h4>\r\n<ul>\r\n");
#nullable restore
#line 44 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
     foreach(string course in courses)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 46 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
       Write(course);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "C:\Users\emmel\OneDrive\Skrivbord\ASP.NET med C#\Moment 1\RazorTest\Pages\Razor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.RazorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.RazorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.RazorModel>)PageContext?.ViewData;
        public MyApp.Namespace.RazorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
