#pragma checksum "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c012fd66fe0d03fd8cb8c43528ca10d29e76df7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Practica_No3.Pages.Pages_Cajero), @"mvc.1.0.razor-page", @"/Pages/Cajero.cshtml")]
namespace Practica_No3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\_ViewImports.cshtml"
using Practica_No3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c012fd66fe0d03fd8cb8c43528ca10d29e76df7d", @"/Pages/Cajero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ab904e2b0010f76b0241a1a988556374766cfa", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cajero : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
  


    //Declaracion de los billetes
    int billetes_de_100 = 0;
    int billetes_de_500 = 0;
    int billetes_de_1000 = 0;
    int transaccion = 1000;


    //Variable que expresa el dinero a retirar
    int monto = 2000;

    //Igualamos la cantidad de dinero al monto
    int cant = 0;
    cant = monto;

    //Igualamos la cantidad de dinero al monto

    //Proceso (Agregamos el limite total del dinero disponible)
    if (monto <= 28400 && monto > 0)
    {

        //Proceso de los billetes de 1000
        if (monto / 1000 > 9)
        {
            billetes_de_1000 = 9;
            monto = monto - 1000 * 9;
        }
        else
        {
            billetes_de_1000 = monto / 1000;
            monto = monto - 1000 * billetes_de_1000;
        }
        //Proceso de los billetes de 500
        if (monto / 500 > 19)
        {
            billetes_de_500 = 19;
            monto = monto - 500 * 19;
        }
        else
        {
            billetes_de_500 = monto / 500;
            monto = monto - 500 * billetes_de_500;
        }

        //Proceso de los billetes de 100

        if (monto / 100 > 99)
        {
            billetes_de_100 = 99;
            monto = monto - 100 * 99;
        }
        else
        {
            billetes_de_100 = monto / 100;
            monto = monto - 100 * billetes_de_100;
        }
    }

    var fondos = "";
    //Establecemos el limite de dinero disponible
    if (monto > 28400)

    {

        fondos = "No hay fondos suficientes. El total de monto disponible";
    }
    else
    {
        fondos = "Hay fondos suficientes";
    }

    string mil;
    string quinientos;
    string cien;
    //Salida estandar


    mil = "Billetes de 1000 : " + billetes_de_1000;
    quinientos = "Billetes de 500 : " + billetes_de_500;
    cien = "Billetes de 100 : " + billetes_de_100;


    var transaccionMsm = "";
    if (transaccion <= 2000)
    {
        transaccionMsm = "La transaccion fue realizada con exito";
    }
    else
    {
        transaccionMsm = "La transaccion no fue realizada con exito.";
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
  

    .titulo {
        color: darkcyan;
    }
</style>

<h1>Cajero automatico del banco ABC</h1>
<p>
    Cree una pagina con un formulario que funcione como cajero automático
    para el banco ABC. El cajero tendrá un límite de billetes descrito a continuación:
    9 de 1000, 19 de 500, 99 de 100
    El cajero debe solicitar Banco y monto a retirar. Si el banco es ABC el limite de
    retiro son 10,000 y 2000 pesos por transacción en caso contrario.
    El cajero debe informar si el monto solicitado no puede ser dispensado o si
    excede el límite de transacción. Y debe hacer la distribución de los billetes de
    acuerdo al monto. Por ejemplo, si el usuario solicita 3,900 y hay disponibilidad en
    todos los billetes, el cajero debe dispensar 3 billetes de mil, 1 de quinientos y 4 de
    cien.
</p>



<h4 class=""titulo"">Retiros</h4>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c012fd66fe0d03fd8cb8c43528ca10d29e76df7d6735", async() => {
                WriteLiteral("\r\n    \r\n    <label><b>El monto es:</b>  ");
#nullable restore
#line 128 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                           Write(cant);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <label><b>Billetes de cien:</b>  ");
#nullable restore
#line 129 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                                Write(cien);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <label><b>Billetes de quinientos:</b>  ");
#nullable restore
#line 130 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                                      Write(quinientos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <label><b>Billetes de mil:</b>  ");
#nullable restore
#line 131 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                               Write(mil);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <label><b>Estado de los fondos:</b>  ");
#nullable restore
#line 132 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                                    Write(fondos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h4 class=\"titulo\">Transacciones</h4>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c012fd66fe0d03fd8cb8c43528ca10d29e76df7d9799", async() => {
                WriteLiteral("\r\n\r\n    <label><b>Monto de la transaccion:</b>  ");
#nullable restore
#line 138 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                                       Write(transaccion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label><br />\r\n    <label><b>Estado de la transaccion:</b>  ");
#nullable restore
#line 139 "C:\Users\Intel\Documents\Cursos\Compuciencias\ASP .NET Core\Semana ll\Practica_No3\Practica_No3\Pages\Cajero.cshtml"
                                        Write(transaccionMsm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Practica_No3.Pages.CajeroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practica_No3.Pages.CajeroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Practica_No3.Pages.CajeroModel>)PageContext?.ViewData;
        public Practica_No3.Pages.CajeroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591