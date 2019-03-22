﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using Ignia.Topics.Editor.Models.Attributes;
using Ignia.Topics.Internal.Diagnostics;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Ignia.Topics.Editor.Mvc.Infrastructure {

  /*============================================================================================================================
  | CLASS: EDITOR ATTRIBUTE (MODEL BINDER PROVIDER)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Determines whether a binding request should use the <see cref="EditorAttributeModelBinder"/>—and, if so, returns a
  ///   reference to the <see cref="EditorAttributeModelBinder"/> type in response.
  /// </summary>
  public class EditorAttributeModelBinderProvider : IModelBinderProvider {

    /*==========================================================================================================================
    | METHOD: GET BINDER
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Binds the incoming post to the <see cref="EditorBindingModel"/>.
    /// </summary>
    /// <remarks>
    ///   The <see cref="CreateModel(ControllerContext, ModelBindingContext, Type)"/> method is called by the MVC framework, via
    ///   convention, when it attempts to bind a model with a corresponding name.
    /// </remarks>
    public IModelBinder GetBinder(ModelBinderProviderContext context) {

      /*------------------------------------------------------------------------------------------------------------------------
      | VALIDATE INPUT
      \-----------------------------------------------------------------------------------------------------------------------*/
      Contract.Requires<ArgumentNullException>(context != null, $"A {nameof(ModelBinderProviderContext)} reference is required.");

      /*------------------------------------------------------------------------------------------------------------------------
      | RETURN BINDER (IF APPROPRIATE)
      \-----------------------------------------------------------------------------------------------------------------------*/
      if (context.Metadata.ModelType == typeof(EditorAttribute)) {
        return new BinderTypeModelBinder(typeof(EditorAttributeModelBinder));
      }
      return null;

    }

  } // Class
} // Namespace
