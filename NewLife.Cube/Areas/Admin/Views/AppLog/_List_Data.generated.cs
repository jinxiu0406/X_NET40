﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
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
    
    #line 7 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    
    #line 4 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/AppLog/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_AppLog__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<NewLife.Cube.Entity.AppLog>>
    {
        public _Areas_Admin_Views_AppLog__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 11 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();
    var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 24 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 849), Tuple.Create("\"", 888)
            
            #line 25 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 856), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 856), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 941), Tuple.Create("\"", 983)
            
            #line 26 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 948), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("AppID"))
            
            #line default
            #line hidden
, 948), false)
);

WriteLiteral(">应用</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1036), Tuple.Create("\"", 1079)
            
            #line 27 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1043), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Action"))
            
            #line default
            #line hidden
, 1043), false)
);

WriteLiteral(">操作</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1132), Tuple.Create("\"", 1177)
            
            #line 28 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1139), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl(" Success"))
            
            #line default
            #line hidden
, 1139), false)
);

WriteLiteral(">成功</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">内容</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1275), Tuple.Create("\"", 1324)
            
            #line 30 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1282), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateUserID"))
            
            #line default
            #line hidden
, 1282), false)
);

WriteLiteral(">创建者</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1378), Tuple.Create("\"", 1423)
            
            #line 31 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateIP"))
            
            #line default
            #line hidden
, 1385), false)
);

WriteLiteral(">IP地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1503), Tuple.Create("\"", 1550)
            
            #line 32 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1510), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("CreateTime"))
            
            #line default
            #line hidden
, 1510), false)
);

WriteLiteral(">时间</a></th>\r\n");

            
            #line 33 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 36 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 40 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 40 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 43 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2013), Tuple.Create("\"", 2031)
            
            #line 45 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2021), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2021), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 46 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2170), Tuple.Create("\"", 2197)
, Tuple.Create(Tuple.Create("", 2177), Tuple.Create("App?ID=", 2177), true)
            
            #line 48 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2184), Tuple.Create<System.Object, System.Int32>(entity.AppID
            
            #line default
            #line hidden
, 2184), false)
);

WriteLiteral(">");

            
            #line 48 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                              Write(entity.AppName);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n                <td>");

            
            #line 49 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
               Write(entity.Action);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2330), Tuple.Create("\"", 2393)
, Tuple.Create(Tuple.Create("", 2338), Tuple.Create("glyphicon", 2338), true)
, Tuple.Create(Tuple.Create(" ", 2347), Tuple.Create("glyphicon-", 2348), true)
            
            #line 51 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2358), Tuple.Create<System.Object, System.Int32>(entity.Success ? "ok" : "remove"
            
            #line default
            #line hidden
, 2358), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2394), Tuple.Create("\"", 2445)
, Tuple.Create(Tuple.Create("", 2402), Tuple.Create("color:", 2402), true)
            
            #line 51 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                     , Tuple.Create(Tuple.Create(" ", 2408), Tuple.Create<System.Object, System.Int32>(entity.Success ? "green" : "red"
            
            #line default
            #line hidden
, 2409), false)
, Tuple.Create(Tuple.Create("", 2444), Tuple.Create(";", 2444), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" style=\"max-width:600px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2580), Tuple.Create("\"", 2602)
            
            #line 53 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                , Tuple.Create(Tuple.Create("", 2588), Tuple.Create<System.Object, System.Int32>(entity.Remark
            
            #line default
            #line hidden
, 2588), false)
);

WriteLiteral(">");

            
            #line 53 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                                                                                                           Write(entity.Remark);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                  Write(UserX.FindByID(entity.CreateUserID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteAttribute("title", Tuple.Create(" title=\"", 2726), Tuple.Create("\"", 2764)
            
            #line 55 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2734), Tuple.Create<System.Object, System.Int32>(entity.CreateIP.IPToAddress()
            
            #line default
            #line hidden
, 2734), false)
);

WriteLiteral(">");

            
            #line 55 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                                                      Write(entity.CreateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 56 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
               Write(entity.CreateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 57 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 57 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 62 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 64 "..\..\Areas\Admin\Views\AppLog\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
