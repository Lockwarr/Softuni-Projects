using SolidExercises.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SolidExercises
{

        public class LogFile : ILogFile
        {
            private StringBuilder stringBuilder;
            public LogFile()
            {
                this.stringBuilder = new StringBuilder();
            }
            public void Write(string message)
            {
                stringBuilder.AppendLine(message);
                File.AppendAllText("log.txt", message + Environment.NewLine);
            }
            public int Size => this.stringBuilder.ToString()
                .Where(c => c >= 'a' && c <= 'z' ||
                            c >= 'A' && c <= 'Z')
                .Sum(c => c);
        }

    }