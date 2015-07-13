using System.Collections.Generic;
using System.Linq;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Symbols;
using Rubberduck.UI;

namespace Rubberduck.Inspections
{
    public class UnassignedVariableUsageInspection //: IInspection // disabled
    {
        public UnassignedVariableUsageInspection()
        {
            Severity = CodeInspectionSeverity.Warning;
        }

        public string Name { get { return RubberduckUI.UnassignedVariableUsage_; } }
        public CodeInspectionType InspectionType { get { return CodeInspectionType.CodeQualityIssues; } }
        public CodeInspectionSeverity Severity { get; set; }

        public IEnumerable<CodeInspectionResultBase> GetInspectionResults(VBProjectParseResult parseResult)
        {
            var usages = parseResult.Declarations.Items.Where(declaration => !declaration.IsBuiltIn 
                && declaration.DeclarationType == DeclarationType.Variable
                && !declaration.References.Any(reference => reference.IsAssignment))
                .SelectMany(declaration => declaration.References);

            foreach (var issue in usages)
            {
                //todo: add context to IdentifierReference
                //yield return new UnassignedVariableUsageInspectionResult(string.Format(Name, issue.Context.GetText()), Severity, issue.Context, issue.QualifiedName);
            }

            return null;
        }
    }
}