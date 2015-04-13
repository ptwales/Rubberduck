using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Vbe.Interop;
using Rubberduck.Extensions;
using Rubberduck.VBA;
using Rubberduck.VBA.Grammar;

namespace Rubberduck.Inspections
{
    public class ObsoleteCallStatementUsageInspectionResult : CodeInspectionResultBase
    {
        public ObsoleteCallStatementUsageInspectionResult(string inspection, CodeInspectionSeverity type,
            QualifiedContext<VBParser.ExplicitCallStmtContext> qualifiedContext)
            : base(inspection, type, qualifiedContext.QualifiedName, qualifiedContext.Context)
        {
        }

        private new VBParser.ExplicitCallStmtContext Context { get { return base.Context as VBParser.ExplicitCallStmtContext;} }

        public override IDictionary<string, Action<VBE>> GetQuickFixes()
        {
            return new Dictionary<string, Action<VBE>>
            {
                {"Remove obsolete statement", RemoveObsoleteStatement}
            };
        }

        private void RemoveObsoleteStatement(VBE vbe)
        {
            var module = vbe.FindCodeModules(QualifiedName).SingleOrDefault();
            if (module == null)
            {
                return;
            }

            var selection = Context.GetSelection();
            var originalCodeLines = module.get_Lines(selection.StartLine, selection.LineCount);
            var originalInstruction = Context.GetText();

            string procedure;
            VBParser.ArgsCallContext arguments;
            if (Context.ECS_MemberProcedureCall() != null)
            {
                procedure = Context.ECS_MemberProcedureCall().ambiguousIdentifier().GetText();
                arguments = Context.ECS_MemberProcedureCall().argsCall();
            }
            else
            {
                procedure = Context.ECS_ProcedureCall().ambiguousIdentifier().GetText();
                arguments = Context.ECS_ProcedureCall().argsCall();
            }

            module.DeleteLines(selection.StartLine, selection.LineCount);

            var argsList = arguments == null
                ? new[] { string.Empty }
                : arguments.argCall().Select(e => e.GetText());
            var newInstruction = procedure + ' ' + string.Join(", ", argsList);
            var newCodeLines = originalCodeLines.Replace(originalInstruction, newInstruction);

            module.InsertLines(selection.StartLine, newCodeLines);
        }
    }
}