﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Rubberduck.VBA.Parser
{
    [ComVisible(false)]
    public abstract class SyntaxTreeNode
    {
        protected SyntaxTreeNode(Instruction instruction, string scope, Match match = null, IEnumerable<SyntaxTreeNode> childNodes = null)
        {
            _instruction = instruction;
            _scope = scope;
            _match = match;
            if (childNodes != null)
            {
                _childNodes = childNodes as IList<SyntaxTreeNode> ?? childNodes.ToList();
            }
        }

        private readonly Instruction _instruction;
        public Instruction Instruction { get { return _instruction; } }

        private readonly string _scope;
        public string Scope { get { return _scope; } }

        private readonly IList<SyntaxTreeNode> _childNodes;
        public IEnumerable<SyntaxTreeNode> ChildNodes { get { return _childNodes; } }

        internal void AddNode(SyntaxTreeNode node)
        {
            _childNodes.Add(node);
        }

        public bool HasChildNodes { get { return _childNodes != null; } }

        private readonly Match _match;
        protected Match RegexMatch { get { return _match; } }

        public IEnumerable<Instruction> FindAllComments()
        {
            return FindAllComments(this);
        }

        /// <summary>
        /// Gets all <see cref="Instruction"/> objects in the specified node, that contain a comment.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static IEnumerable<Instruction> FindAllComments(SyntaxTreeNode node)
        {
            if (!string.IsNullOrEmpty(node.Instruction.Comment))
            {
                yield return node.Instruction;
            }

            if (node.ChildNodes == null) yield break;
            foreach (var childNode in node.ChildNodes.ToList())
            {
                var instructions = FindAllComments(childNode);
                foreach (var instruction in instructions)
                {
                    yield return instruction;
                }
            }
        }

        public IEnumerable<ProcedureNode> FindAllProcedures(ProcedureKind? kind = null)
        {
            var result = FindAllProcedures(this);
            return kind.HasValue ? result.Where(e => e.Kind == kind) : result;
        }

        public static IEnumerable<ProcedureNode> FindAllProcedures(SyntaxTreeNode node)
        {
            if (node.ChildNodes == null)
            {
                yield break;
            }

            foreach (var procNode in node.ChildNodes)
            {
                if (procNode.HasChildNodes && procNode.ChildNodes.Any())
                {
                    foreach (var childNode in procNode.ChildNodes.OfType<ProcedureNode>())
                    {
                        yield return childNode;
                    }
                }
            }
        }

        public IEnumerable<DeclarationNode> FindAllDeclarations()
        {
            return FindAllDeclarations(this);
        }

        public static IEnumerable<DeclarationNode> FindAllDeclarations(SyntaxTreeNode node)
        {
            if (node is DeclarationNode)
            {
                yield return node as DeclarationNode;
            }

            if (node.ChildNodes == null) yield break;
            foreach (var childNode in node.ChildNodes.ToList())
            {
                var declarations = FindAllDeclarations(childNode);
                foreach (var declaration in declarations)
                {
                    yield return declaration;
                }
            }
        }
    }
}
