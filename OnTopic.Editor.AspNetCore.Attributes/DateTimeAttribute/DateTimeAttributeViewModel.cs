﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System;
using System.Globalization;
using OnTopic.Editor.AspNetCore.Models;
using OnTopic.Editor.AspNetCore.Models.Metadata;

namespace OnTopic.Editor.AspNetCore.Attributes.DateTimeAttribute {

  /*============================================================================================================================
  | CLASS: DATE/TIME  ATTRIBUTE (VIEW MODEL)
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Represents the data model for the <see cref="DateTimeViewComponent"/>. Additionally provides access to the underlying
  ///   <see cref="AttributeDescriptorTopicViewModel"/> as well as the instance values for that attribute from the currently
  ///   selected <see cref="Topic"/>.
  /// </summary>
  public record DateTimeAttributeViewModel: AttributeViewModel<DateTimeAttributeDescriptorTopicViewModel> {

    /*==========================================================================================================================
    | PRIVATE VARIABLES
    \-------------------------------------------------------------------------------------------------------------------------*/
    private readonly            IFormatProvider                 _format                         = CultureInfo.InvariantCulture;
    private                     DateTime?                       _value;

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of the <see cref="DateTimeSelectorAttributeViewModel"/> class.
    /// </summary>
    public DateTimeAttributeViewModel(
      EditingTopicViewModel currentTopic,
      DateTimeAttributeDescriptorTopicViewModel attributeDescriptor,
      string value = null,
      string inheritedValue = null
    ): base(
      currentTopic,
      attributeDescriptor,
      value,
      inheritedValue
    ) {}

    /*==========================================================================================================================
    | PROPERTY: DATE/TIME VALUE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Determines if the <see cref="Value"/> is set and, if so, returns that value as a <see cref="DateTime"/> object;
    ///   otherwise returns the current <see cref="DateTime"/>.
    /// </summary>
    public DateTime DateTimeValue {
      get {
        if (_value is not null) {
          return _value.Value;
        }
        else if (!String.IsNullOrEmpty(Value) && DateTime.TryParse(Value, out var dateTimeValue)) {
          _value = dateTimeValue;
        }
        else {
          _value = CalculateOffset(DateTime.Now);
        }
        return _value.Value;
      }
    }

    /*==========================================================================================================================
    | PROPERTY: FORMATTED VALUE
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Parses the <see cref="Value"/> and returns the full date and time in the format expected by the date/time control.
    /// </summary>
    public string FormattedValue {
      get {
        if (AttributeDescriptor.IncludeDatePicker is not null || AttributeDescriptor.IncludeTimePicker is not null) {
          if (AttributeDescriptor.IncludeDatePicker is true && AttributeDescriptor.IncludeTimePicker is true) {
            return DateTimeValue.ToString("o");
          }
          else if (AttributeDescriptor.IncludeDatePicker is true) {
            return ToDateString();
          }
          else if (AttributeDescriptor.IncludeTimePicker is true) {
            return ToTimeString();
          };
        }
        return DateTimeValue.ToString("o");
      }
    }

    /*==========================================================================================================================
    | METHOD: TO DATE STRING
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Parses the <see cref="Value"/> and returns the date portion in the format expected by the date/time control.
    /// </summary>
    public string ToDateString() => DateTimeValue.ToString("yyyy-MM-dd", _format);

    /*==========================================================================================================================
    | METHOD: TO TIME STRING
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Parses the <see cref="Value"/> and returns the date portion in the format expected by the date/time control.
    /// </summary>
    public string ToTimeString() => DateTimeValue.ToString("hh:mm:ss", _format);

    /*==========================================================================================================================
    | METHOD: CALCULATE OFFSET
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Given a date, applies any offsets applied to the date and time.
    /// </summary>
    public DateTime CalculateOffset(DateTime originalDate) {
      var offset = AttributeDescriptor.DateTimeOffset?? 0;
      if (AttributeDescriptor.DateTimeOffset is 0) return originalDate;
      return AttributeDescriptor.DateTimeOffsetUnits switch {
        "Minutes"               => originalDate.AddMinutes(offset),
        "Hours"                 => originalDate.AddHours(offset),
        "Days"                  => originalDate.AddDays(offset),
        "Months"                => originalDate.AddMonths(offset),
        "Years"                 => originalDate.AddYears(offset),
        _                       => originalDate.AddDays(offset),
      };
      ;

    }

  } // Class
} // Namespace