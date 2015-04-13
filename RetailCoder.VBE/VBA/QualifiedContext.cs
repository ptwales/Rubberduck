using System.Linq;
using Rubberduck.Inspections;

namespace Rubberduck.VBA
{
    public class QualifiedContext<TContext>
    {
        public QualifiedContext(QualifiedMemberName memberName, TContext context)
            : this(memberName.ModuleScope, context)
        {
            _member = memberName;
        }

        public QualifiedContext(QualifiedModuleName qualifiedName, TContext context)
        {
            _qualifiedName = qualifiedName;
            _context = context;
        }

        private readonly QualifiedMemberName _member;
        public QualifiedMemberName MemberName { get { return _member; } }

        private readonly QualifiedModuleName _qualifiedName;
        public QualifiedModuleName QualifiedName { get { return _qualifiedName; } }

        private readonly TContext _context;
        public TContext Context { get { return _context; } }

        public override int GetHashCode()
        {
            return Context.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as QualifiedContext<TContext>;
            if (other == null)
            {
                return false;
            }

            return other.GetHashCode() == GetHashCode();
        }

        public static bool operator ==(QualifiedContext<TContext> context1, QualifiedContext<TContext> context2)
        {
            if (((object)context1) == null)
            {
                return ((object)context2) == null;
            }

            return context1.Equals(context2);
        }

        public static bool operator !=(QualifiedContext<TContext> context1, QualifiedContext<TContext> context2)
        {
            if (((object)context1) == null)
            {
                return ((object)context2) != null;
            }

            return !context1.Equals(context2);
        }
    }
}
