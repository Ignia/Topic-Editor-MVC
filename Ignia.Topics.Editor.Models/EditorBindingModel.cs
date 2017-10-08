﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using Ignia.Topics.Editor.Models.Collections;

namespace Ignia.Topics.Editor.Models {

  /*============================================================================================================================
  | CLASS: EDITOR BINDING MODEL
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents a model for retrieving data from the editor interface, primarily as a collection of
  ///   <see cref="EditorAttribute"/> instances, via the <see cref="EditorAttributeCollection"/>.
  /// </summary>
  /// <remarks>
  /// </remarks>
  public class EditorBindingModel {

    /*==========================================================================================================================
    | PRIVATE VARIABLES
    \-------------------------------------------------------------------------------------------------------------------------*/

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of the <see cref="AttributeValue"/> class, using the specified key/value pair.
    /// </summary>
    public EditorBindingModel() {
      Attributes = new EditorAttributeCollection();
    }

    /*==========================================================================================================================
    | ATTRIBUTES
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Collection of attribute values extracted from the post.
    /// </summary>
    public EditorAttributeCollection Attributes {
      get;
      set;
    }

  } //Class

} //Namespace