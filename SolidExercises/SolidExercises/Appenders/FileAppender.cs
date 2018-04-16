using SolidExercises;
using SolidExercises.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Appenders
{
    public class FileAppender:IAppender
    {
        public ILayout Layout { get; }
        public FileAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.Info, ILogFile logFile = null)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
            this.MessagesAppended = 0;
            this.File = logFile;
        }
        public ILogFile File { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended { get; private set; }

        public void Append(IMessage message)

        {
            if (this.File == null)
            {
                throw new InvalidOperationException("Log file cannot be null!");
            }
            this.File.Write(this.Layout.FormatMessage(message));
            this.MessagesAppended++;
        }
    }
}


