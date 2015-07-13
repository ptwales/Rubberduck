using System.Collections.Generic;
using System.Linq;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Symbols;
using Rubberduck.UI;

namespace Rubberduck.Inspections
{
    public class VariableNotUsedInspection : IInspection
    {
        public VariableNotUsedInspection()
        {
            Severity = CodeInspectionSeverity.Warning;
        }

        public string Name { get { return "VariableNotUsedInspection"; } }
        public string Description { get { return RubberduckUI.VariableNotUsed_; } }
        public CodeInspectionType InspectionType { get { return CodeInspectionType.CodeQualityIssues; } }
        public CodeInspectionSeverity Severity { get; set; }

        public IEnumerable<CodeInspectionResultBase> GetInspectionResults(VBProjectParseResult parseResult)
        {
            var declarations = parseResult.Declarations.Items.Where(declaration =>
                !declaration.IsBuiltIn 
                //&& !declaration.IsArray()
                && declaration.DeclarationType == DeclarationType.Variable
                && declaration.References.All(reference => reference.IsAssignment));

            foreach (var issue in declarations)
            {
                yield return new IdentifierNotUsedInspectionResult(string.Format(Description, issue.IdentifierName), Severity, ((dynamic)issue.Context).ambiguousIdentifier(), issue.QualifiedName.QualifiedModuleName);
            }
        }
    }
}