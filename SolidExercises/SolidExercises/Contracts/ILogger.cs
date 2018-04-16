using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Contracts
{
    public interface ILogger
    {
        void Critical(string dateTime, string message);
        void Error(string dateTime, string message);
        void Fatal(string dateTime, string message);
        void Info(string dateTime, string message);
        void Warn(string dateTime, string message);

    }
}
