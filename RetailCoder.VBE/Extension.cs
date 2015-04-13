﻿using System;
using Extensibility;
using Microsoft.Vbe.Interop;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace Rubberduck
{
    [ComVisible(true)]
    [Guid(ClassId)]
    [ProgId(ProgId)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    //underscores make classes invisible to VB6 object explorer
    //Nothing breaks because we declare a ProgId
    public class _Extension : IDTExtensibility2, IDisposable
    {
        public const string ClassId = "8D052AD8-BBD2-4C59-8DEC-F697CA1F8A66";
        public const string ProgId = "Rubberduck.Extension";

        private App _app;

        public void OnAddInsUpdate(ref Array custom)
        {
        }

        public void OnBeginShutdown(ref Array custom)
        {
        }

        public void OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            try
            {
                _app = new App((VBE)Application, (AddIn)AddInInst);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Rubberduck Add-In Could Not Be Loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnStartupComplete(ref Array custom)
        {
            if (_app != null)
            {
                _app.CreateExtUi();
            }
        }

        public void OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing & _app != null)
            {
                _app.Dispose();
            }
        }
    }
}
