﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using System.Diagnostics.CodeAnalysis;

namespace OnTopic.Editor.AspNetCore.Models.ClientResources {

  /*============================================================================================================================
  | CLASS: CLIENT RESOURCE
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents a resource that should be exposed to the client, such as a stylesheet or script.
  /// </summary>
  public abstract class ClientResource {

    /*==========================================================================================================================
    | URL
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Gets or sets the URL associated with the client-side resource.
    /// </summary>
    [NotNull, DisallowNull]
    public Uri? Url { get; set; }

  }
}