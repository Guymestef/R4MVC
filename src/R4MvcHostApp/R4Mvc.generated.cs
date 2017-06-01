
// <auto-generated />
// This file was generated by a R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and rebuild.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

namespace R4MvcHostApp.Controllers
{
    public partial class AccountController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public AccountController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected AccountController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Login()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Login);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Register()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Register);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLogin()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLogin);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLoginCallback()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginCallback);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ExternalLoginConfirmation()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ExternalLoginConfirmation);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ConfirmEmail()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ConfirmEmail);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ResetPassword()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ResetPassword);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult SendCode()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.SendCode);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult VerifyCode()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.VerifyCode);
        }

        [GeneratedCode("R4Mvc", "1.0")]
        public AccountController Actions => MVC.Account;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Account";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Account";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ActionNamesClass ActionNames => s_actions;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Login = "Login";
            public readonly string Register = "Register";
            public readonly string Logout = "Logout";
            public readonly string ExternalLogin = "ExternalLogin";
            public readonly string ExternalLoginCallback = "ExternalLoginCallback";
            public readonly string ExternalLoginConfirmation = "ExternalLoginConfirmation";
            public readonly string ConfirmEmail = "ConfirmEmail";
            public readonly string ForgotPassword = "ForgotPassword";
            public readonly string ForgotPasswordConfirmation = "ForgotPasswordConfirmation";
            public readonly string ResetPassword = "ResetPassword";
            public readonly string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public readonly string SendCode = "SendCode";
            public readonly string VerifyCode = "VerifyCode";
            public readonly string AccessDenied = "AccessDenied";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Login = "Login";
            public const string Register = "Register";
            public const string Logout = "Logout";
            public const string ExternalLogin = "ExternalLogin";
            public const string ExternalLoginCallback = "ExternalLoginCallback";
            public const string ExternalLoginConfirmation = "ExternalLoginConfirmation";
            public const string ConfirmEmail = "ConfirmEmail";
            public const string ForgotPassword = "ForgotPassword";
            public const string ForgotPasswordConfirmation = "ForgotPasswordConfirmation";
            public const string ResetPassword = "ResetPassword";
            public const string ResetPasswordConfirmation = "ResetPasswordConfirmation";
            public const string SendCode = "SendCode";
            public const string VerifyCode = "VerifyCode";
            public const string AccessDenied = "AccessDenied";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ViewsClass Views => s_views;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            [GeneratedCode("R4Mvc", "1.0")]
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_AccountController : R4MvcHostApp.Controllers.AccountController
    {
        public R4MVC_AccountController(): base (Dummy.Instance)
        {
        }
    }

    public partial class HomeController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public HomeController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected HomeController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0")]
        public HomeController Actions => MVC.Home;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Home";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Home";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ActionNamesClass ActionNames => s_actions;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string About = "About";
            public readonly string Contact = "Contact";
            public readonly string Error = "Error";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string About = "About";
            public const string Contact = "Contact";
            public const string Error = "Error";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ViewsClass Views => s_views;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            [GeneratedCode("R4Mvc", "1.0")]
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_HomeController : R4MvcHostApp.Controllers.HomeController
    {
        public R4MVC_HomeController(): base (Dummy.Instance)
        {
        }
    }

    public partial class ManageController
    {
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public ManageController()
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected ManageController(Dummy d)
        {
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<IActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(IActionResult result)
        {
            var callInfo = result.GetR4MvcResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<IActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult Index()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.Index);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult RemoveLogin()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.RemoveLogin);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult VerifyPhoneNumber()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.VerifyPhoneNumber);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult ManageLogins()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.ManageLogins);
        }

        [NonAction]
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public virtual IActionResult LinkLogin()
        {
            return new R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(Area, Name, ActionNames.LinkLogin);
        }

        [GeneratedCode("R4Mvc", "1.0")]
        public ManageController Actions => MVC.Manage;
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Area = "";
        [GeneratedCode("R4Mvc", "1.0")]
        public readonly string Name = "Manage";
        [GeneratedCode("R4Mvc", "1.0")]
        public const string NameConst = "Manage";
        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ActionNamesClass ActionNames => s_actions;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string RemoveLogin = "RemoveLogin";
            public readonly string AddPhoneNumber = "AddPhoneNumber";
            public readonly string EnableTwoFactorAuthentication = "EnableTwoFactorAuthentication";
            public readonly string DisableTwoFactorAuthentication = "DisableTwoFactorAuthentication";
            public readonly string VerifyPhoneNumber = "VerifyPhoneNumber";
            public readonly string RemovePhoneNumber = "RemovePhoneNumber";
            public readonly string ChangePassword = "ChangePassword";
            public readonly string SetPassword = "SetPassword";
            public readonly string ManageLogins = "ManageLogins";
            public readonly string LinkLogin = "LinkLogin";
            public readonly string LinkLoginCallback = "LinkLoginCallback";
        }

        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string RemoveLogin = "RemoveLogin";
            public const string AddPhoneNumber = "AddPhoneNumber";
            public const string EnableTwoFactorAuthentication = "EnableTwoFactorAuthentication";
            public const string DisableTwoFactorAuthentication = "DisableTwoFactorAuthentication";
            public const string VerifyPhoneNumber = "VerifyPhoneNumber";
            public const string RemovePhoneNumber = "RemovePhoneNumber";
            public const string ChangePassword = "ChangePassword";
            public const string SetPassword = "SetPassword";
            public const string ManageLogins = "ManageLogins";
            public const string LinkLogin = "LinkLogin";
            public const string LinkLoginCallback = "LinkLoginCallback";
        }

        [GeneratedCode("R4Mvc", "1.0")]
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("R4Mvc", "1.0")]
        public ViewsClass Views => s_views;
        [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            [GeneratedCode("R4Mvc", "1.0")]
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class R4MVC_ManageController : R4MvcHostApp.Controllers.ManageController
    {
        public R4MVC_ManageController(): base (Dummy.Instance)
        {
        }
    }
}

namespace Links
{
}

namespace R4Mvc
{
    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        [GeneratedCode("R4Mvc", "1.0")]
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static R4MvcHostApp.Controllers.AccountController Account = new R4MvcHostApp.Controllers.R4MVC_AccountController();
    public static R4MvcHostApp.Controllers.HomeController Home = new R4MvcHostApp.Controllers.R4MVC_HomeController();
    public static R4MvcHostApp.Controllers.ManageController Manage = new R4MvcHostApp.Controllers.R4MVC_ManageController();
}

internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult : IActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller
    {
        get;
        set;
    }

    public string Action
    {
        get;
        set;
    }

    public string Protocol
    {
        get;
        set;
    }

    public RouteValueDictionary RouteValueDictionary
    {
        get;
        set;
    }

    public Task ExecuteResultAsync(ActionContext context)
    {
        return Task.FromResult(0);
    }
}
#pragma warning restore 1591, 3008, 3009, 0108

