﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnTopic.Editor.AspNetCore.Models.Components {

  /*============================================================================================================================
  | CLASS: CONTENT TYPE LIST (VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides a view model for displaying a navigable list of content types.
  /// </summary>
  public record ContentTypeListViewModel {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of the <see cref="ContentTypeListViewModel"/> class.
    /// </summary>
    public ContentTypeListViewModel() { }

    /*==========================================================================================================================
    | PROPERTY: CURRENT TOPIC
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a reference to the <see cref="EditingTopicViewModel"/> that the user is currently editing.
    /// </summary>
    public EditingTopicViewModel? CurrentTopic { get; init; }

    /*==========================================================================================================================
    | TOPIC LIST
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a list of key/value pairs associated with the topic lookup.
    /// </summary>
    /// <remarks>
    ///   The key represents the value that will be persisted to the <see cref="Topic.Attributes"/> collection. The value
    ///   represents the label as it will be displayed in the interface. For instance, for a <see
    ///   cref="TopicListAttributeViewModel"/> representing countries, <c>US</c> might by the key associated with a <c>United
    ///   States</c> value.
    /// </remarks>
    public Collection<SelectListItem> TopicList { get; } = new();

    /*==========================================================================================================================
    | ATTRIBUTE KEY
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Denotes the attribute associated with the content type list, if any. This is used to access the modal window and
    ///   ensure any elements are uniquely identified.
    /// </summary>
    public string? AttributeKey { get; init; }

    /*==========================================================================================================================
    | ENABLE MODAL
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   If a <see cref="TargetUrl"/> is supplied, and <see cref="EnableModal"/> is set to <c>true</c>, then the <see
    ///   cref="TargetUrl"/> will be loaded in a modal window. Otherwise, the <see cref="TargetUrl"/> will be loaded via a
    ///   redirect. The default is <c>false</c>.
    /// </summary>
    public bool? EnableModal { get; init; }

    /*==========================================================================================================================
    | ON MODAL CLOSE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   If supplied, sets a reference to a callback function to execute on close of the editor modal window.
    /// </summary>
    public string? OnModalClose { get; init; }

  } // Class
} // Namespace