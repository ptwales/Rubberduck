using System;
using System.Collections.Generic;
using Antlr4.Runtime;
using Rubberduck.UI;
using Rubberduck.VBEditor;

namespace Rubberduck.Inspections
{
    public class IdentifierNotUsedInspectionResult : CodeInspectionResultBase
    {
        public IdentifierNotUsedInspectionResult(string inspection, CodeInspectionSeverity type,
            ParserRuleContext context, QualifiedModuleName qualifiedName)
            : base(inspection, type, qualifiedName, context)
        {
        }

        public override IDictionary<string, Action> GetQuickFixes()
        {
            return
                new Dictionary<string, Action>
                {
                    {RubberduckUI.Inspections_RemoveUnusedDeclaration, RemoveUnusedDeclaration}
                };
        }

        protected virtual void RemoveUnusedDeclaration()
        {
            var module = QualifiedName.Component.CodeModule;
            var selection = QualifiedSelection.Selection;

            var originalCodeLines = module.get_Lines(selection.StartLine, selection.LineCount)
                .Replace("\r\n", " ")
                .Replace("_", string.Empty);

            var originalInstruction = Context.GetText();
            module.DeleteLines(selection.StartLine, selection.LineCount);

            var newInstruction = string.Empty;
            var newCodeLines = string.IsNullOrEmpty(newInstruction)
                ? string.Empty
                : originalCodeLines.Replace(originalInstruction, newInstruction);

            if (!string.IsNullOrEmpty(newCodeLines))
            {
                module.InsertLines(selection.StartLine, newCodeLines);
            }
        }
    }
}