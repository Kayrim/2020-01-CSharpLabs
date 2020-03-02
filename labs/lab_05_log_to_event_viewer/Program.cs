using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_05_log_to_event_viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog.WriteEntry("Application", "Your system is about to expire - run for the hills!",
                EventLogEntryType.Error,5000,1234);
        }
    }
}
