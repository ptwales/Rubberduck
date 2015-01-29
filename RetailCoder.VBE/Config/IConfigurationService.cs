﻿using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Rubberduck.Config
{
    [ComVisible(false)]
    public interface IConfigurationService
    {
        CodeInspection[] GetDefaultCodeInspections();
        Configuration GetDefaultConfiguration();
        ToDoMarker[] GetDefaultTodoMarkers();
        IList<Rubberduck.Inspections.IInspection> GetImplementedCodeInspections();
        List<Rubberduck.VBA.Grammar.ISyntax> GetImplementedSyntax();
        Configuration LoadConfiguration();
        void SaveConfiguration<T>(T toSerialize);
    }
}
