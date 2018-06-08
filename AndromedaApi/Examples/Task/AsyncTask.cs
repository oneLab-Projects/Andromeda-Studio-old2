﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AndromedaApi.Components;

namespace AndromedaApi.Examples.Task
{
    [TaskInfo(true, true)]
    public class AsyncTask : Components.Task
    {
        public override void Run()
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                while (true)
                {
                    if (Status == TaskStatus.Running)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine("Hello world");
                    }
                    else if (Status == TaskStatus.Error || Status == TaskStatus.Cancelled)
                        break;
                }
                Status = TaskStatus.Finished;
            });
            Status = TaskStatus.Running;
        }
    }
}