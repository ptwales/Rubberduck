﻿using System.Collections.Generic;
using Rubberduck.Parsing;

namespace Rubberduck.Inspections
{
    /// <summary>
    /// An interface that abstracts a runnable code inspection.
    /// </summary>
    public interface IInspection : IInspectionModel
    {
        /// <summary>
        /// Runs code inspection on specified parse trees.
        /// </summary>
        /// <returns>Returns inspection results, if any.</returns>
        IEnumerable<CodeInspectionResultBase> GetInspectionResults(VBProjectParseResult parseResult);
    }
}
