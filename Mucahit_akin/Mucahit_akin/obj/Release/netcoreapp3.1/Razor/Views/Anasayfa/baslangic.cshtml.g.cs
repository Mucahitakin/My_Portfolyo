#pragma checksum "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab305edddcb2ec0b4246ed82925dc59b84fe4780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_baslangic), @"mvc.1.0.view", @"/Views/Anasayfa/baslangic.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab305edddcb2ec0b4246ed82925dc59b84fe4780", @"/Views/Anasayfa/baslangic.cshtml")]
    #nullable restore
    public class Views_Anasayfa_baslangic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mucahit_akin.Model.Anasayfa>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
  
    ViewData["Title"] = "Anasayfa";  
    Layout = "~/Shared/_Layout.cshtml";

    string r1 = "https://kurtuluskara.com/wp-content/uploads/2017/04/Web-Tasarimci-Nasil-Olunur.jpg";
    string r2 = "https://www.cagdasyazilim.com/images/slider/d41d8cd98f00b204e9800998ecf8427e1.jpg";
    string r3 = "https://www.cagdasyazilim.com/images/slider/d41d8cd98f00b204e9800998ecf8427e2.jpg";
    string txt = "Mücahit Akın";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"slideshow-container\">\r\n<div class=\"mySlides fade\">\r\n  <div class=\"numbertext\"></div>\r\n  <img");
            BeginWriteAttribute("src", " src=", 591, "", 599, 1);
#nullable restore
#line 15 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
WriteAttributeValue("", 596, r1, 596, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:415px;\">\r\n  <div class=\"text\">");
#nullable restore
#line 16 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
               Write(txt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n<div class=\"mySlides fade\">\r\n  <div class=\"numbertext\"></div>\r\n  <img");
            BeginWriteAttribute("src", " src=", 744, "", 752, 1);
#nullable restore
#line 20 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
WriteAttributeValue("", 749, r2, 749, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:415px;\">\r\n  <div class=\"text\">");
#nullable restore
#line 21 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
               Write(txt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div    >\r\n</div>\r\n<div class=\"mySlides fade\">\r\n  <div class=\"numbertext\"></div>\r\n  <img");
            BeginWriteAttribute("src", " src=", 901, "", 909, 1);
#nullable restore
#line 25 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
WriteAttributeValue("", 906, r3, 906, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;height:415px;\">\r\n  <div class=\"text\">");
#nullable restore
#line 26 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
               Write(txt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n</div>\r\n<br>\r\n<div style=\"text-align:center\">\r\n  <span class=\"dot\"></span> \r\n  <span class=\"dot\"></span> \r\n  <span class=\"dot\"></span> \r\n</div>\r\n");
            WriteLiteral(@"<style>
.slideshow-container {
  max-width: 96%;
  position: relative;
  margin: auto;
}

.text {
  color: #f2f2f2;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

.dot {
  height: 13px;
  width: 13px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}
.active {
  background-color: #717171;
}

.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}
");
            WriteLiteral("@-webkit-keyframes fade {\r\n  from {opacity: .4} \r\n  to {opacity: 1}\r\n}\r\n");
            WriteLiteral("@keyframes fade {\r\n  from {opacity: .4} \r\n  to {opacity: 1}\r\n}\r\n/* On smaller screens, decrease text size */\r\n");
            WriteLiteral(@"@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}


</style>
<script> 
var slideIndex = 0; 
showSlides();
function showSlides() {
    var i;
    var slides = document.getElementsByClassName(""mySlides"");
    var dots = document.getElementsByClassName(""dot"");
    for (i = 0; i < slides.length; i++) {
       slides[i].style.display = ""none"";  
    }
    slideIndex++;
    if (slideIndex> slides.length) {slideIndex = 1}    
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace("" active"", """");
    }
    slides[slideIndex-1].style.display = ""block"";  
    dots[slideIndex-1].className += "" active"";
    setTimeout(showSlides, 3000);
}
</script>
");
#nullable restore
#line 116 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"






    /////////////////////////////////////////////////////////////////////////////////////////////////////////////;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\" style=\"width:100%;height:270px;margin-left:0px;margin-top:100px;\">\r\n    <h1 style=\"margin-left:30%;\">Projelerde Kullandığım Uygulama ve diller</h1>\r\n        <div class=\"project-name\">\r\n");
#nullable restore
#line 127 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
              
                foreach (var item in Model)
                {

                    if (item.id <= 5)
                    {                 
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 3339, "\"", 3354, 1);
#nullable restore
#line 134 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
WriteAttributeValue("", 3345, item.url, 3345, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:200px;margin-left:65px;border-radius:50%;\" />\r\n");
#nullable restore
#line 135 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
                    }

                  
               
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"container\" style=\"width:100%;height:200px;margin-left:0px;margin-top:30px;\">\r\n        <div class=\"project-name\">\r\n");
#nullable restore
#line 146 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
              
                foreach (var item in Model)
                {

                    if (item.id >= 6)
                    {                 
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 3883, "\"", 3898, 1);
#nullable restore
#line 153 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
WriteAttributeValue("", 3889, item.url, 3889, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:200px;width:200px;margin-left:65px;border-radius:50%;\" />\r\n");
#nullable restore
#line 154 "C:\Users\pc\Desktop\IASU_Dersler\hakkimda_web\Mucahit_akin\Mucahit_akin\Views\Anasayfa\baslangic.cshtml"
                    }

                  
               
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mucahit_akin.Model.Anasayfa>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591