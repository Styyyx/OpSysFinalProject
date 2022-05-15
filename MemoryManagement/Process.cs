using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    internal class Process
    {
        string Task;
        string JobName;
        int JobSize;
        public Process(string task, string jobName, int jobSize)
        {
            Task = task;
            JobName = jobName;
            JobSize = jobSize;
        }
        
    }
}
