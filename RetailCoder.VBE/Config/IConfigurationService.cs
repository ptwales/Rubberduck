﻿using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Rubberduck.Config
{
    public interface IConfigurationService
    {
        CodeInspectionSetting[] GetDefaultCodeInspections();
        Configuration GetDefaultConfiguration();
        ToDoMarker[] GetDefaultTodoMarkers();
        IList<Rubberduck.Inspections.IInspection> GetImplementedCodeInspections();
        Configuration LoadConfiguration();
        void SaveConfiguration<T>(T toSerialize);
    }
}
