﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_List_Toolbar.cshtml")]
    public partial class _Areas_Admin_Views_User__List_Toolbar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__List_Toolbar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"tableTools-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 230), Tuple.Create("\"", 311)
            
            #line 10 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Url.Action("index")
            
            #line default
            #line hidden
, 239), false)
            
            #line 10 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
, Tuple.Create(Tuple.Create("", 259), Tuple.Create<System.Object, System.Int32>(Html.Raw("?" + page.GetBaseUrl(false, true, true))
            
            #line default
            #line hidden
, 259), false)
, Tuple.Create(Tuple.Create(" ", 310), Tuple.Create("", 310), true)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
             if (ManageProvider.User.Has(PermissionFlags.Insert))
            {
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
           Write(Html.ActionLink("添加" + ViewContext.Controller.GetType().GetDisplayName(), "Add", null, new { @class = "btn btn-success btn-sm" }));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
                                                                                                                                                  
            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"pull-right form-group\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"RoleID\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">角色：</label>\r\n");

WriteLiteral("                    ");

            
            #line 18 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
               Write(Html.ForDropDownList("RoleID", Role.FindAllWithCache(), "全部", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 21 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
               Write(Html.Partial("_List_Toolbar_Search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 22 "..\..\Areas\Admin\Views\User\_List_Toolbar.cshtml"
               Write(Html.Partial("_List_Toolbar_Adv"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>" +
"\r\n");

        }
    }
}
#pragma warning restore 1591
