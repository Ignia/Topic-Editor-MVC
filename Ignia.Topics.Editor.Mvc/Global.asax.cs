﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Web.Mvc;
using System.Web.Routing;
using Ignia.Topics.Editor.Models.Attributes;

namespace Ignia.Topics.Editor.Mvc {

  /*============================================================================================================================
  | CLASS: GLOBAL
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides default configuration for the application, including any special processing that needs to happen relative to
  ///   application events (such as <see cref="Application_Start"/> or <see cref="System.Web.HttpApplication.Error"/>.
  /// </summary>
  public class MvcApplication : System.Web.HttpApplication {

    /*==========================================================================================================================
    | METHOD: APPLICATION START (EVENT HANDLER)
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides initial configuration for the application, including registration of MVC routes via the
    ///   <see cref="RouteConfig"/> class.
    /// </summary>
    protected void Application_Start() {

      /*------------------------------------------------------------------------------------------------------------------------
      | CONFIGURE APPLICATION
      \-----------------------------------------------------------------------------------------------------------------------*/
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);

      /*------------------------------------------------------------------------------------------------------------------------
      | CUSTOM CONFIGURATION
      \-----------------------------------------------------------------------------------------------------------------------*/
      ModelBinders.Binders.Add(typeof(EditorAttribute), new EditorAttributeModelBinder());
      ControllerBuilder.Current.SetControllerFactory(new EditorControllerFactory());

    }

  } //Class

} //Namespace
