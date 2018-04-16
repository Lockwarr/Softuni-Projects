using SolidExercises;
using SolidExercises.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; }

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
            this.MessagesAppended = 0;
        }
        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }

        public void Append(IMessage message)

        {
            if (message.ReportLevel < this.ReportLevel)
            {
                return;
            }
            Console.WriteLine(this.Layout.FormatMessage(message));
            this.MessagesAppended++;
        }
    }
}

