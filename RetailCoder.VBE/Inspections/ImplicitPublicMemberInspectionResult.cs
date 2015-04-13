using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Microsoft.Vbe.Interop;
using Rubberduck.Extensions;
using Rubberduck.VBA;

namespace Rubberduck.Inspections
{
    public class ImplicitPublicMemberInspectionResult : CodeInspectionResultBase
    {
        public ImplicitPublicMemberInspectionResult(string inspection, CodeInspectionSeverity type, QualifiedContext<ParserRuleContext> qualifiedContext)
            : base(inspection,type, qualifiedContext.QualifiedName, qualifiedContext.Context)
        {
        }

        public override IDictionary<string, Action<VBE>> GetQuickFixes()
        {
            return new Dictionary<string, Action<VBE>>
            {
                { "Specify Public access modifier explicitly",  SpecifyPublicModifier}
            };
        }

        private void SpecifyPublicModifier(VBE vbe)
        {
            var oldContent = Context.GetText();
            var newContent = Tokens.Public + ' ' + oldContent;

            var selection = QualifiedSelection.Selection;

            var module = vbe.FindCodeModules(QualifiedName.ProjectName, QualifiedName.ModuleName).First();
            var lines = module.get_Lines(selection.StartLine, selection.LineCount);

            var result = lines.Replace(oldContent, newContent);
            module.DeleteLines(selection.StartLine, selection.EndLine - 1);
            module.InsertLines(selection.StartLine, result);
        }
    }
}