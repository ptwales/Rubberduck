﻿using System.Collections.Generic;
using System.Linq;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Grammar;
using Rubberduck.VBA.Nodes;

namespace Rubberduck.Inspections
{
    public class ObsoleteCommentSyntaxInspection : IInspection
    {
        /// <summary>
        /// Parameterless constructor required for discovery of implemented code inspections.
        /// </summary>
        public ObsoleteCommentSyntaxInspection()
        {
            Severity = CodeInspectionSeverity.Suggestion;
        }

        public string Name { get { return InspectionNames.ObsoleteComment; } }
        public CodeInspectionType InspectionType { get {return CodeInspectionType.LanguageOpportunities; } }
        public CodeInspectionSeverity Severity { get; set; }

        public IEnumerable<CodeInspectionResultBase> GetInspectionResults(VBProjectParseResult parseResult)
        {
            var modules = parseResult.ComponentParseResults.ToList();
            foreach (var comment in modules.SelectMany(module => module.Comments))
            {
                if (comment.Marker == Tokens.Rem)
                {
                    yield return new ObsoleteCommentSyntaxInspectionResult(Name, Severity, comment);
                }
            }
        }
    }
}