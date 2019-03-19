﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Threading.Tasks;
using Ignia.Topics.Editor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ignia.Topics.AspNetCore.Mvc.Components {

  /*============================================================================================================================
  | CLASS: WYSIWYG (VIEW COMPONENT)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Delivers a view model for a WYSIWYG attribute type.
  /// </summary>
  public class WysiwygViewComponent : AttributeTypeViewComponentBase {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a <see cref="WysiwygViewComponent"/> with necessary dependencies.
    /// </summary>
    public WysiwygViewComponent(ITopicRoutingService topicRoutingService) : base(topicRoutingService) { }

    /*==========================================================================================================================
    | METHOD: INVOKE (ASYNC)
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Assembles the view model for the <see cref="WysiwygViewComponent"/>.
    /// </summary>
    public async Task<IViewComponentResult> InvokeAsync(AttributeDescriptorTopicViewModel attribute, string Id) =>
      View(GetAttributeViewModel(attribute));

  } // Class
} // Namespace