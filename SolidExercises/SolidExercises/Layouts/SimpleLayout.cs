using SolidExercises.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string messageFormat = "{0} - {1} - {2}";
        public string FormatMessage(IMessage message)
        {
            return string.Format(messageFormat, message.DateTime, message.ReportLevel, message.MessageText);
        }
    }
}
