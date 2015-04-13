using System.Collections.Generic;
using System.Linq;
using Rubberduck.Inspections;
using Rubberduck.VBA.Grammar;

namespace Rubberduck.VBA.ParseTreeListeners
{
    public class VariableReferencesListener : VBListenerBase, IExtensionListener<VBParser.AmbiguousIdentifierContext>
    {
        private readonly QualifiedModuleName _qualifiedName;
        private readonly IList<QualifiedContext<VBParser.AmbiguousIdentifierContext>> _members = 
            new List<QualifiedContext<VBParser.AmbiguousIdentifierContext>>();

        private QualifiedMemberName _currentMember;

        public VariableReferencesListener(QualifiedModuleName qualifiedName)
        {
            _qualifiedName = qualifiedName;
            _currentMember = new QualifiedMemberName(_qualifiedName, string.Empty);
        }

        public IEnumerable<QualifiedContext<VBParser.AmbiguousIdentifierContext>> Members { get { return _members; } }

        public override void EnterAmbiguousIdentifier(VBParser.AmbiguousIdentifierContext context)
        {
            var ignored = new[]
            {
                typeof (VBParser.AsTypeClauseContext),
                typeof (VBParser.VariableSubStmtContext),
                typeof (VBParser.ConstSubStmtContext),
                typeof (VBParser.SubStmtContext), 
                typeof (VBParser.FunctionStmtContext),
                typeof (VBParser.PropertyGetStmtContext),
                typeof (VBParser.PropertyLetStmtContext),
                typeof (VBParser.PropertySetStmtContext)
            };

            if (ignored.All(type => type != context.Parent.GetType()))
            {
                _members.Add(new QualifiedContext<VBParser.AmbiguousIdentifierContext>(_currentMember, context));
            }
        }

        public override void EnterSubStmt(VBParser.SubStmtContext context)
        {
            _currentMember = new QualifiedMemberName(_qualifiedName, context.AmbiguousIdentifier().GetText());
        }

        public override void EnterFunctionStmt(VBParser.FunctionStmtContext context)
        {
            _currentMember = new QualifiedMemberName(_qualifiedName, context.AmbiguousIdentifier().GetText());
        }

        public override void EnterPropertyGetStmt(VBParser.PropertyGetStmtContext context)
        {
            _currentMember = new QualifiedMemberName(_qualifiedName, context.AmbiguousIdentifier().GetText());
        }

        public override void EnterPropertyLetStmt(VBParser.PropertyLetStmtContext context)
        {
            _currentMember = new QualifiedMemberName(_qualifiedName, context.AmbiguousIdentifier().GetText());
        }

        public override void EnterPropertySetStmt(VBParser.PropertySetStmtContext context)
        {
            _currentMember = new QualifiedMemberName(_qualifiedName, context.AmbiguousIdentifier().GetText());
        }
    }
}