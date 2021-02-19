﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Diagnostics.CodeAnalysis;
using OnTopic.Editor.AspNetCore.Models.Metadata;
using OnTopic.Mapping.Annotations;
using OnTopic.Metadata;
using OnTopic.ViewModels;

namespace OnTopic.Editor.AspNetCore.Attributes.TopicReferenceAttribute {

  /*============================================================================================================================
  | CLASS: TOPIC REFERENCE ATTRIBUTE DESCRIPTOR (VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides access to attributes associated with the <see cref="TopicReferenceViewComponent"/>.
  /// </summary>
  public record TopicReferenceAttributeDescriptorViewModel: AttributeDescriptorViewModel {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a <see cref="TopicReferenceAttributeDescriptorViewModel"/>
    /// </summary>
    public TopicReferenceAttributeDescriptorViewModel() {
      StyleSheets.Register(GetNamespacedUri("/Shared/Styles/token-input.min.css"));
      StyleSheets.Register(GetNamespacedUri("/Shared/Styles/token-input-facebook.min.css"));
      Scripts.Register(GetNamespacedUri("/Shared/Scripts/jquery-tokeninput.min.js"));
      Scripts.Register(GetNamespacedUri("/Shared/Scripts/TokenizedTopicList.js"));
    }

    /*==========================================================================================================================
    | PROPERTY: ROOT TOPIC
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets a <see cref="Topic.Id"/> representing the scope of <see cref="Topic"/>s to display to the user. This
    ///   allows relationships to be targeted to particular areas of the topic graph.
    /// </summary>
    [AttributeKey("RootTopicId")]
    [NotNull]
    public TopicViewModel? RootTopic { get; init; }

    /*==========================================================================================================================
    | RESULT LIMIT
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets the maximum number of <see cref="Topic"/> results to pull from the web service.
    /// </summary>
    public int? ResultLimit { get; init; } = 100;

    /*==========================================================================================================================
    | TARGET CONTENT TYPE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets the <see cref="Topic.Key"/> of the <see cref="ContentTypeDescriptor"/> to filter results by.
    /// </summary>
    public string? TargetContentType { get; init; }

  } //Class
} //Namespace