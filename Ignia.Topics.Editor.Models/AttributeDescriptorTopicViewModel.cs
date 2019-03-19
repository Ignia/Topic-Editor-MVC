﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Collections.Generic;
using Ignia.Topics.Metadata;

namespace Ignia.Topics.Editor.Models {

  /*============================================================================================================================
  | CLASS: ATTRIBUTE DESCRIPTOR TOPIC VIEW MODEL
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides core properties from a <see cref="AttributeDescriptor"/> to a view component.
  /// </summary>
  public class AttributeDescriptorTopicViewModel: ViewModels.TopicViewModel {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of the <see cref="AttributeDescriptorTopicViewModel"/> class.
    /// </summary>
    public AttributeDescriptorTopicViewModel() {}

    /*==========================================================================================================================
    | PROPERTY: DESCRIPTION
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a friendly description for the <see cref="AttributeDescriptor"/>, intended as documentation for users of the
    ///   editor.
    /// </summary>
    public string Description { get; set; }

    /*==========================================================================================================================
    | PROPERTY: MODEL TYPE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines how the attribute is modeled in terms of the object-oriented code (e.g., as a relationship? An attribute?).
    /// </summary>
    public ModelType ModelType { get; set; }

    /*==========================================================================================================================
    | PROPERTY: EDITOR TYPE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a reference to the view to use to reprensent this attribute in the topic editor.
    /// </summary>
    public string EditorType { get; set; }

    /*==========================================================================================================================
    | PROPERTY: DISPLAY GROUP
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines what group of attributes to associate the current attribute with.
    /// </summary>
    public string DisplayGroup { get; set; }

    /*==========================================================================================================================
    | PROPERTY: DEFAULT CONFIGURATION
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides the raw string representation of any optional values needed to configure the attribute editor.
    /// </summary>
    public string DefaultConfiguration { get; set; }

    /*==========================================================================================================================
    | PROPERTY: CONFIGURATION
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Provides a parsed version of the <see cref="DefaultConfiguration"/>, with key/value pairs being represented in a
    ///   dictionary for easy reference.
    /// </summary>
    public Dictionary<string, string> Configuration { get; set; }

    /*==========================================================================================================================
    | METHOD: GET CONFIGURATION VALUE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Retrieves a configuration value from the <see cref="Configuration"/> dictionary; if the value doesn't exist, then
    ///   optionally returns a default value.
    /// </summary>
    public string GetConfigurationValue(string key, string defaultValue = null) {
      if (Configuration != null && Configuration.ContainsKey(key) && Configuration[key] != null) {
        return Configuration[key].ToString();
      }
      return defaultValue;
    }

    /*==========================================================================================================================
    | PROPERTY: IS REQUIRED?
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines whether the attribute should be considered required or not.
    /// </summary>
    public bool IsRequired { get; set; }

    /*==========================================================================================================================
    | PROPERTY: DEFAULT VALUE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Establishes the default value to use if the use doesn't enter a value.
    /// </summary>
    public string DefaultValue { get; set; }

  } // Class

} // Namespace
