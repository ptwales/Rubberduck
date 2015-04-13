﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rubberduck.VBEHost
{
    public abstract class HostApplicationBase<TApplication> : IHostApplication
        where TApplication : class
    {
        protected readonly TApplication Application;
        protected HostApplicationBase(string applicationName)
        {
            Application = (TApplication)Marshal.GetActiveObject(applicationName + ".Application");
        }

        ~HostApplicationBase()
        {
            Marshal.ReleaseComObject(Application);
        }

        public abstract void Run(string projectName, string moduleName, string methodName);
        protected abstract string GenerateMethodCall(string projectName, string moduleName, string methodName);

        public TimeSpan TimedMethodCall(string projectName, string moduleName, string methodName)
        {
            var stopwatch = Stopwatch.StartNew();

            Run(projectName, moduleName, methodName);

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}