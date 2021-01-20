﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using System.Collections.ObjectModel;
using OnTopic.Mapping.Annotations;
using OnTopic.Metadata;

#nullable enable

namespace OnTopic.Editor.Models.Metadata {

  /*============================================================================================================================
  | CLASS: NESTED TOPIC LIST ATTRIBUTE (TOPIC VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides access to attributes associated with the <see cref="NestedTopicListViewComponentView"/>.
  /// </summary>
  public record NestedTopicListAttributeTopicViewModel: AttributeDescriptorTopicViewModel {

    /*==========================================================================================================================
    | PROPERTY: CONTENT TYPES
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets a list of comma-delimited list of content types that should be displayed in this list.
    /// </summary>
    /// <remarks>
    ///   As an example, if the <see cref="ContentTypes"/> value is <c>AttributeDescriptor,ContentTypeDescriptor</c> then the
    ///   <see cref="NestedTopicListViewComponent"/> should only display topics of the types <see cref="AttributeDescriptor"/>
    ///   or <see cref="ContentTypeDescriptor"/>.
    /// </remarks>
    [Obsolete(
      "This is maintained exclusively for backward compatibility with the legacy DefaultConfiguration attribute. New attribute " +
      "definitions should instead use the new PermittedContentTypes attribute.",
      false)
    ]
    public string? ContentTypes { get; init; } = "";

    /*==========================================================================================================================
    | PROPERTY: PERMITTED CONTENT TYPES
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines which <see cref="ContentType"/>s, if any, are permitted to be created as part of the configured <see
    ///   cref="NestedTopicListAttributeViewComponent"/>.
    /// </summary>
    [Follow(Relationships.None)]
    [Relationship("ContentTypes", Type=RelationshipType.Relationship)]
    public Collection<ContentTypeDescriptorTopicViewModel> PermittedContentTypes { get; } = new();

    /*==============================================================================================================================
    | ENABLE MODAL
    \-----------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   By default, nested topics will open in a modal window. Optionally, this functionality can be disabled.
    /// </summary>
    /// <remarks>
    ///   This is useful in the scenario where a <see cref="ContentTypeDescriptor"/> has multiple levels of attributes implementing
    ///   <see cref="NestedTopicListViewComponent"/>. This is not a recommended configuration, but is occassionally necessary for
    ///   modeling especially complicated scenarios, such as cases where there are multiple dimensions for each topic (e.g.,
    ///   language, device type, &c.). In those cases, nested topics may be the best way to model the capabilities, but having
    ///   multiple levels of modal windows is a poor user experience.
    /// </remarks>
    public bool? EnableModal { get; init; } = true;

  } //Class
} //Namespace

#nullable restore