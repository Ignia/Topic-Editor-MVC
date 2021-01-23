﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using OnTopic.Editor.AspNetCore.Models;
using OnTopic.Editor.AspNetCore.Models.Metadata;

namespace OnTopic.Editor.AspNetCore.Attributes.BooleanAttribute {

  /*============================================================================================================================
  | CLASS: BOOLEAN ATTRIBUTE (VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents the data model for the <see cref="BooleanViewComponent"/>. Additionally provides access to the underlying
  ///   <see cref="AttributeDescriptorTopicViewModel"/> as well as the instance values for that attribute from the currently
  ///   selected <see cref="Topic"/>.
  /// </summary>
  public record BooleanAttributeViewModel: AttributeViewModel<BooleanAttributeDescriptorTopicViewModel> {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of the <see cref="BooleanAttributeViewModel"/> class.
    /// </summary>
    public BooleanAttributeViewModel(
      EditingTopicViewModel currentTopic,
      BooleanAttributeDescriptorTopicViewModel attributeDescriptor,
      string value = null,
      string inheritedValue = null
    ): base(
      currentTopic,
      attributeDescriptor,
      value,
      inheritedValue
    ) {}

    /*==========================================================================================================================
    | IS TRUE?
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines whether the value is explicitly set to true.
    /// </summary>
    public bool? IsTrue() {
      if (
        (Value?.Equals("1", StringComparison.OrdinalIgnoreCase)?? false) ||
        (Value?.Equals("true", StringComparison.OrdinalIgnoreCase)?? false)
      ) {
        return true;
      }
      return null;
    }

    /*==========================================================================================================================
    | IS FALSE?
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines whether value is explicitly set to false.
    /// </summary>
    public bool? IsFalse() {
      if (
        (Value?.Equals("0", StringComparison.OrdinalIgnoreCase) ?? false) ||
        (Value?.Equals("false", StringComparison.OrdinalIgnoreCase) ?? false)
      ) {
        return false;
      }
      return null;
    }


  } // Class
} // Namespace