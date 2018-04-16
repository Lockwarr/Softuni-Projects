using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Contracts
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        int MessagesAppended { get; }

        ILayout Layout { get; }

        void Append(IMessage message);
    }
}
