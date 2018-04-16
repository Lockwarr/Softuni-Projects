using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Contracts
{
    public interface IMessage
    {
        string DateTime { get; }
        ReportLevel ReportLevel { get; }
        string MessageText { get; }
    }
}
