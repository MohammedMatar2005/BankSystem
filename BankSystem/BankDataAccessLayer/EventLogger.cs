using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public static class EventLogger
    {
        public static void Log(
            string message,
            EventLogEntryType type,
            DateTime? errorDateTime = null,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePath = "",
            [CallerLineNumber] int lineNumber = 0)
        {
            DateTime logTime = errorDateTime ?? DateTime.Now;

            string logMessage = $"[{logTime}] Error in {memberName} at {filePath}:{lineNumber} - {message}";

            EventLog.WriteEntry("DVLD_Application", logMessage, type);
        }

    }
}
