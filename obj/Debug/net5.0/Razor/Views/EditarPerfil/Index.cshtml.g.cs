#pragma checksum "C:\Users\fic\Desktop\Andre\Instadev_SENAI\Views\EditarPerfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51ade62cc6a753ac746049cc668c9727770df552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditarPerfil_Index), @"mvc.1.0.view", @"/Views/EditarPerfil/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fic\Desktop\Andre\Instadev_SENAI\Views\_ViewImports.cshtml"
using Instadev_SENAI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fic\Desktop\Andre\Instadev_SENAI\Views\_ViewImports.cshtml"
using Instadev_SENAI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ade62cc6a753ac746049cc668c9727770df552", @"/Views/EditarPerfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8b5fcd01e6898dc70d457300e4123286932b29", @"/Views/_ViewImports.cshtml")]
    public class Views_EditarPerfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Perfil>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\fic\Desktop\Andre\Instadev_SENAI\Views\EditarPerfil\Index.cshtml"
  
    ViewData["Title"] = "Página de Edição de Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <header class=""topo"">
        <div class=""container"">
                <div class=""logo"">
                    <a href=""#""><img src=""../wwwroot/Images/Instadev.svg"" alt=""Logo do InstaDev""></a>
                 </div> <!--Fim do Logo -->
                    <div class=""pesquisa"">                        
                        <input class=""camp"" type=""text"" placeholder=""&#xF002; Pesquisar""");
            BeginWriteAttribute("value", " value=\"", 479, "\"", 487, 0);
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""1"" autocomplete=""off"">
                     </div> <!--Fim da Pesquisa -->
                <nav class=""menu""> 
                    <ul class=""icons"">
                        <il><a href=""#""><i class=""fas fa-home"" style=""font-size:25px;color:black""></i> </a></il>
                        <il><a href=""#""><i class=""far fa-paper-plane"" style=""font-size:25px;color:black""></i> </a></il>
                        <il><a href=""#""><i class=""far fa-compass"" style=""font-size:25px;color:black""></i> </a></il>
                        <il><a href=""#""><i class=""far fa-heart"" style=""font-size:25px;color:black""></i> </a></il>
                        <il><a href=""#""><i class=""fas fa-user-circle"" style=""font-size:27px;color:black""></i> </a></il>
                    </ul>
                </nav>    
        </div>
    </header> 

 <section class=""alinhamento"">
    <section class=""conteudo"">
        <div class=""aba"">
            <h1>Editar Perfil</h1>
        </div>
        <div class=""informacoes"">
    ");
            WriteLiteral(@"        <div class=""foto"">
                <div class=""foto1"">
                    <i class=""fas fa-user-circle"" style=""font-size:50px;color:black""></i> 
                </div>
                <div class=""foto2"">
                    <h2>Default_Name</h2>
                    <a href=""#"" class=""btn"">Alterar foto do perfil</a>
                </div>
            </div>

            <div class=""nome"">
                <div class=""nome1"">
                    <h3>Nome</h3>
                        <div class=""campo1"">
                            <input type=""text"" name=""nome"" class=""campo"">
                        </div>                      
                </div>
                <div class=""nome2"">                      
                    <p>Ajude as pessoas a descobrir sua conta usando o nome pelo qual<br> você é conhecido: seu nome completo, apelido ou nome comercial.</p>
                    <p>Você pode alterar o seu nome apenas duas vezes a cada 14 dias.</p>
                </div>
         ");
            WriteLiteral(@"   </div>

            <div class=""nome-user"">
                <div class=""nome-user1"">
                    <h3>Nome de usuário</h3>
                        <div class=""campo2"">
                            <input type=""text"" name=""nome"" class=""campo"">
                        </div>
                </div>
                <div class=""nome-user2"">
                    <p>Na maioria dos casos, você poderá alterar seu nome de usuário<br> novamente para nascimento_tr por mais 14 dias.</p>
                </div>
            </div>
            <div class=""email"">
                <div class=""email1"">
                    <h4 class=""titulo"">Informações pessoais</h4>
                    <p>Forneça suas informações pessoais, mesmo se a conta for usada<br> para uma empresa, um animal de estimação ou outra coisa. Elas<br> não farão parte do seu perfil público.</p>
                </div>
                <div class=""email2"">
                    <h3>E-mail</h3>
                        <div class=""campo3"">
 ");
            WriteLiteral(@"                           <input type=""text"" name=""nome"" class=""campo"">
                        </div>
                </div>
            </div>
            <div class=""bnts"">
                <button class=""btn"">Enviar</button>
                <a href=""#"" class=""desativar"">Desativar minha conta definitivamente</a>
            </div>
        </div>
    </section>
    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Perfil> Html { get; private set; }
    }
}
#pragma warning restore 1591
