﻿using System.Collections.Generic;
using Rubberduck.VBA.Grammar;

namespace Rubberduck.VBA.Nodes
{
    public class ConstDeclarationNode : Node
    {
        public ConstDeclarationNode(VBParser.ConstStmtContext context, string scope, bool isLocal = false)
            : base(context, scope, null, new List<Node>())
        {
            foreach (var constant in context.ConstSubStmt())
            {
                AddChild(new DeclaredIdentifierNode(constant, scope, context.Visibility(), isLocal));
            }
        }
    }

    public class VariableDeclarationNode : Node
    {
        public VariableDeclarationNode(VBParser.VariableStmtContext context, string scope)
            : base(context, scope, null, new List<Node>())
        {
            foreach (var variable in context.VariableListStmt().VariableSubStmt())
            {
                AddChild(new DeclaredIdentifierNode(variable, scope, context.Visibility(), context.DIM() != null || context.STATIC() != null));
            }
        }
    }

    public class DeclaredIdentifierNode : Node
    {
        private static readonly IDictionary<string, string> TypeSpecifiers = new Dictionary<string, string>
        {
            { "%", Tokens.Integer },
            { "&", Tokens.Long },
            { "@", Tokens.Decimal },
            { "!", Tokens.Single },
            { "#", Tokens.Double },
            { "$", Tokens.String }
        };

        public DeclaredIdentifierNode(VBParser.ConstSubStmtContext context, string scope,
            VBParser.VisibilityContext visibility, bool isLocal)
            : base(context, scope)
        {
            _name = context.AmbiguousIdentifier().GetText();
            if (context.AsTypeClause() == null)
            {
                if (context.TypeHint() == null)
                {
                    _isImplicitlyTyped = true;
                    _typeName = Tokens.Variant;
                }
                else
                {
                    var hint = context.TypeHint().GetText();
                    _isUsingTypeHint = true;
                    _typeName = TypeSpecifiers[hint];
                }
            }
            else
            {
                _typeName = context.AsTypeClause().Type().GetText();
            }

            _accessibility = isLocal ? VBAccessibility.Private : visibility.GetAccessibility();
        }

        public DeclaredIdentifierNode(VBParser.VariableSubStmtContext context, string scope,
                            VBParser.VisibilityContext visibility, bool isLocal = true)
            : base(context, scope)
        {
            _name = context.AmbiguousIdentifier().GetText();
            if (context.AsTypeClause() == null)
            {
                if (context.TypeHint() == null)
                {
                    _isImplicitlyTyped = true;
                    _typeName = Tokens.Variant;
                }
                else
                {
                    var hint = context.TypeHint().GetText();
                    _isUsingTypeHint = true;
                    _typeName = TypeSpecifiers[hint];
                }
            }
            else
            {
                _typeName = context.AsTypeClause().Type().GetText();
            }

            _accessibility = isLocal ? VBAccessibility.Private : visibility.GetAccessibility();
        }

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly string _typeName;
        public string TypeName { get { return _typeName; } }

        private readonly bool _isImplicitlyTyped;
        public bool IsImplicitlyTyped { get { return _isImplicitlyTyped; } }

        private bool _isUsingTypeHint;
        public bool IsUsingTypeHint { get { return _isUsingTypeHint; } }

        private readonly VBAccessibility _accessibility;
        public VBAccessibility Accessibility { get { return _accessibility; } }
    }
}
