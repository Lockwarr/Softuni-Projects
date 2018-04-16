using SolidExercises.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises
{
    public class Message : IMessage
    {
        public Message(string dateTime, ReportLevel reportLevel, string messageText)
        {
            DateTime = dateTime;
            ReportLevel = reportLevel;
            MessageText = messageText;
        }
        public string DateTime { get; }

        public ReportLevel ReportLevel { get; }

        public string MessageText { get; }

    }
}
