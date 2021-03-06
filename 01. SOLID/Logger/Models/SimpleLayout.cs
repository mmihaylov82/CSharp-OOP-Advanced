﻿using Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Models
{
    public class SimpleLayout : ILayout
    {
        //format error.DateTime - error.Level - error.Message
        const string DateFormat = "M/d/yyyy h:mm:ss tt";
        const string Format = "{0} - {1} - {2}";

        public string FormatError(IError error)
        {
            string dateString = error.DateTime.ToString(DateFormat, CultureInfo.InvariantCulture);
            string formattedError = string.Format(Format, dateString, error.Level.ToString(), error.Message);

            return formattedError;
        }
    }
}
