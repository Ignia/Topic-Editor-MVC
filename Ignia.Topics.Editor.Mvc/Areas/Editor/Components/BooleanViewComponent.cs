﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/

using Ignia.Topics.Editor.Models;
using Ignia.Topics.Editor.Models.Components;
using Ignia.Topics.Editor.Models.Components.Options;
using Ignia.Topics.Editor.Models.Components.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ignia.Topics.Editor.Mvc.Components {

  /*============================================================================================================================
  | CLASS: BOOLEAN (VIEW COMPONENT)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Delivers a view model for a boolean attribute type.
  /// </summary>
  public class BooleanViewComponent: AttributeTypeViewComponentBase {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a <see cref="LastModifiedViewComponent"/> with necessary dependencies.
    /// </summary>
    /// <returns>A topic <see cref="NavigationTopicViewComponentBase{T}"/>.</returns>
    public BooleanViewComponent(ITopicRoutingService topicRoutingService) : base(topicRoutingService) { }

    /*==========================================================================================================================
    | METHOD: INVOKE (ASYNC)
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Assembles the view model for the <see cref="DefaultAttributeTypeViewComponent"/>.
    /// </summary>
    public async Task<IViewComponentResult> InvokeAsync(
      AttributeDescriptorTopicViewModel attribute,
      string htmlFieldPrefix,
      BooleanOptions options = null
    ) {
      ViewData.TemplateInfo.HtmlFieldPrefix = htmlFieldPrefix;
      options ??= new BooleanOptions();
      return View(GetAttributeViewModel(new BooleanAttributeViewModel(attribute, options)));
    }

  } // Class

} // Namespace