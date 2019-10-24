using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.MiddlerServices.Quartz
{
    public class ScheduledJob : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            Console.WriteLine("hello quartz!");
            return Task.CompletedTask;
        }
    }
}
