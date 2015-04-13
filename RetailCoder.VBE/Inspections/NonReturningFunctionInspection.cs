using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Rubberduck.VBA;
using Rubberduck.VBA.Grammar;
using Rubberduck.VBA.Nodes;
using Rubberduck.VBA.ParseTreeListeners;

namespace Rubberduck.Inspections
{
    public class NonReturningFunctionInspection : IInspection
    {
        public NonReturningFunctionInspection()
        {
            Severity = CodeInspectionSeverity.Warning;
        }

        public string Name { get { return InspectionNames.NonReturningFunction_; } }
        public CodeInspectionType InspectionType { get { return CodeInspectionType.CodeQualityIssues; } }
        public CodeInspectionSeverity Severity { get; set; }

        public IEnumerable<CodeInspectionResultBase> GetInspectionResults(VBProjectParseResult parseResult)
        {
            foreach (var result in parseResult.ComponentParseResults)
            {
                // todo: in Microsoft Access, this inspection should only return a result for private functions.
                //       changing an unassigned function to a "Sub" could break Access macros that reference it.
                //       doing this right may require accessing the Access object model to find usages in macros.

                var module = result;

                var procedures = result.ParseTree.GetContexts<ProcedureListener, ParserRuleContext>(new ProcedureListener(module.QualifiedName));
                var functions = procedures.Select(context => context.Context).OfType<VBParser.FunctionStmtContext>()
                    .Where(function => function.GetContexts<VariableAssignmentListener, VBParser.AmbiguousIdentifierContext>(new VariableAssignmentListener(module.QualifiedName))
                        .All(assignment => assignment.Context.GetText() != function.AmbiguousIdentifier().GetText()));

                foreach (var unassignedFunction in functions)
                {
                    yield return new NonReturningFunctionInspectionResult(string.Format(Name, unassignedFunction.AmbiguousIdentifier().GetText()), Severity, new QualifiedContext<ParserRuleContext>(result.QualifiedName, unassignedFunction));
                }
            }
        }
    }
}