﻿using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Vbe.Interop;
using Rubberduck.UI;

namespace RubberduckTests.Mocks
{
    /// <summary>
    /// Fake Windows collection to get around Moq's inability to deal with ref params.
    /// </summary>
    /// <remarks>
    /// The <see cref="Window"/> passed into MockWindowCollection's ctor will be returned from <see cref="CreateToolWindow"/>.
    /// </remarks>
    class MockWindowsCollection : Windows
    {
        /// <param name="window">
        /// Expects a window created by <see cref="MockFactory.CreateWindowMock"/>.
        /// This argument will be returned from <see cref="CreateToolWindow"/>.
        /// </param>
        internal MockWindowsCollection(Window window)
        {
            _window = window;
        }

        private readonly Window _window;

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        [SuppressMessage("ReSharper", "RedundantAssignment")]
        public Window CreateToolWindow(AddIn AddInInst, string ProgId, string Caption, string GuidPosition, ref object DocObj)
        {
            DocObj = new _DockableWindowHost(); 
            return _window;
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Window Item(object index)
        {
            throw new NotImplementedException();
        }

        public Application Parent
        {
            get { throw new NotImplementedException(); }
        }

        public VBE VBE
        {
            get { throw new NotImplementedException(); }
        }
    }
}
