using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Contracts
{
    public interface ILogFile
    {
        void Write(string message);
        int Size { get; }
    }
}
