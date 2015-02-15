
// <auto-generated />
// This file was generated by a R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and rebuild.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.AspNet.Mvc;

namespace R4MvcHostApp.Controllers
{
    public partial class AccountController
    {
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public AccountController()
        {
        }

        [GeneratedCode("R4MVC", "1.0")]
        public readonly string Name = "AccountController";
        [GeneratedCode("R4MVC", "1.0")]
        public const string NameConst = "AccountController";
        [GeneratedCode("R4MVC", "1.0")]
        public readonly string Area = "AccountController";
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Login = "Login";
            public readonly string Register = "Register";
            public readonly string Manage = "Manage";
            public readonly string LogOff = "LogOff";
        }

        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Login = "Login";
            public const string Register = "Register";
            public const string Manage = "Manage";
            public const string LogOff = "LogOff";
        }

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_AccountController : R4MvcHostApp.Controllers.AccountController
    {
        public R4MVC_AccountController()
        {
        }
    }

    public partial class HomeController
    {
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public HomeController()
        {
        }

        [GeneratedCode("R4MVC", "1.0")]
        public readonly string Name = "HomeController";
        [GeneratedCode("R4MVC", "1.0")]
        public const string NameConst = "HomeController";
        [GeneratedCode("R4MVC", "1.0")]
        public readonly string Area = "HomeController";
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string About = "About";
            public readonly string Contact = "Contact";
            public readonly string Error = "Error";
        }

        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string About = "About";
            public const string Contact = "Contact";
            public const string Error = "Error";
        }

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_HomeController : R4MvcHostApp.Controllers.HomeController
    {
        public R4MVC_HomeController()
        {
        }
    }
}

namespace R4MVC
{
    [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static R4MvcHostApp.Controllers.AccountController Account = new R4MvcHostApp.Controllers.AccountController();
    public static R4MvcHostApp.Controllers.HomeController Home = new R4MvcHostApp.Controllers.HomeController();
}

namespace Links
{
    [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
    public static class css
    {
        private const string URLPATH = "~/css";
    }

    [GeneratedCode("R4MVC", "1.0"), DebuggerNonUserCode]
    public static class lib
    {
        private const string URLPATH = "~/lib";
    }
}
#pragma warning restore 1591, 3008, 3009, 0108

