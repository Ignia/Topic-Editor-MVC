﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using OnTopic.Editor.AspNetCore.Attributes.QueryableTopicListAttribute;

#nullable enable

namespace OnTopic.Editor.AspNetCore.Attributes.TokenizedTopicListAttribute {

  /*============================================================================================================================
  | CLASS: TOKENIZED TOPIC LIST ATTRIBUTE DESCRIPTOR (VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides access to attributes associated with the <see cref="TokenizedTopicListViewComponent"/>.
  /// </summary>
  public record TokenizedTopicListAttributeDescriptorViewModel: QueryableTopicListAttributeDescriptorViewModel {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a <see cref="TokenizedTopicListAttributeDescriptorViewModel"/>
    /// </summary>
    public TokenizedTopicListAttributeDescriptorViewModel() {
      StyleSheets.Register(GetNamespacedUri("/Shared/Styles/token-input.min.css"));
      StyleSheets.Register(GetNamespacedUri("/Shared/Styles/token-input-facebook.min.css"));
      Scripts.Register(GetNamespacedUri("/Shared/Scripts/jquery-tokeninput.min.js"));
      Scripts.Register(GetNamespacedUri("/Shared/Scripts/TokenizedTopicList.js"));
    }

    /*==========================================================================================================================
    | RESULT LIMIT
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets the maximum number of <see cref="Topic"/> results to pull from the web service.
    /// </summary>
    public int? ResultLimit { get; init; } = 100;

    /*==========================================================================================================================
    | TOKEN LIMIT
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets the maximum number of tokens allowed to be selected by the user. Maps to TokenInput's <c>tokenLimit</c>
    ///   setting.
    /// </summary>
    /// <remarks>
    ///   This is especially useful if an attribute should be limited to a single entry, such as a topic reference, but it is
    ///   preferred to display a searchable list rather than a predefined dropdown list using <see cref="
    ///   TopicLookupViewComponent"/>.
    /// </remarks>
    public int? TokenLimit { get; init; } = 100;

    /*==========================================================================================================================
    | AUTO POST BACK?
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines if the form should automatically be submitted whenever a new value is selected. This is useful, in
    ///   particular, for the <see cref="TopicPointerViewComponent"/>, which provides a purpose-built wrapper for the <see cref=
    ///   "TokenizedTopicViewComponent"/>.
    /// </summary>
    public bool? AutoPostBack { get; init; }

  } //Class
} //Namespace

#nullable restore