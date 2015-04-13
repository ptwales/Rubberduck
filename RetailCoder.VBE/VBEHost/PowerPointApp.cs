﻿using Microsoft.Office.Interop.Excel;

namespace Rubberduck.VBEHost
{
    public class PowerPointApp : HostApplicationBase<Application>
    {
        public PowerPointApp() : base("PowerPoint") { }

        public override void Run(string projectName, string moduleName, string methodName)
        {
            object[] paramArray = { }; //PowerPoint requires a paramarray, so we pass it an empty array.

            var call = GenerateMethodCall(projectName, moduleName, methodName);
            Application.Run(call, paramArray);
        }

        protected override string GenerateMethodCall(string projectName, string moduleName, string methodName)
        {
            /* Note: Powerpoint supports a `FileName.ppt!Module.method` syntax, 
             * but that would require significant changes to the Unit Testing Framework.
             * http://msdn.microsoft.com/en-us/library/office/ff744221(v=office.15).aspx
             */

            return string.Concat(moduleName, ".", methodName);
        }
    }
}