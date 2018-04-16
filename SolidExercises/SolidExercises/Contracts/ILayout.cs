using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExercises.Contracts
{
   public interface ILayout
    {
        string FormatMessage(IMessage message);
    }
}
