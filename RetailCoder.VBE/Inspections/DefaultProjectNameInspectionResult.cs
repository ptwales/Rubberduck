﻿using System;
using System.Collections.Generic;
using Rubberduck.Parsing;
using Rubberduck.Parsing.Symbols;
using Rubberduck.Refactorings.Rename;
using Rubberduck.UI;
using Rubberduck.UI.Refactorings;

namespace Rubberduck.Inspections
{
    public class GenericProjectNameInspectionResult : CodeInspectionResultBase
    {
        private readonly VBProjectParseResult _parseResult;

        public GenericProjectNameInspectionResult(string inspection, CodeInspectionSeverity type, Declaration target, VBProjectParseResult parseResult) 
            : base(inspection, type, target)
        {
            _parseResult = parseResult;
        }

        public override IDictionary<string, Action> GetQuickFixes()
        {
            var project = RubberduckUI.ResourceManager.GetString("DeclarationType_" + DeclarationType.Project, RubberduckUI.Culture);
            return new Dictionary<string, Action>
            {
                { string.Format(RubberduckUI.Rename_DeclarationType, project), RenameProject }
            };
        }

        private void RenameProject()
        {
            var vbe = QualifiedSelection.QualifiedName.Project.VBE;

            using (var view = new RenameDialog())
            {
                var factory = new RenamePresenterFactory(vbe, view, _parseResult);
                var refactoring = new RenameRefactoring(factory);
                refactoring.Refactor(Target);
            }
        }
    }
}
