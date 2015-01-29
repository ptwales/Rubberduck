﻿using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Rubberduck.VBA
{
    [ComVisible(false)]
    public class LabelNode : SyntaxTreeNode
    {
        public LabelNode(Instruction instruction, string scope, Match match)
            : base(instruction, scope, match)
        {
        }

        public string Label
        { 
            get 
            {
                return RegexMatch.Groups["identifier"].Value;
            } 
        }
    }

    [ComVisible(false)]
    public class OptionNode : SyntaxTreeNode
    {
        public OptionNode(Instruction instruction, string scope, Match match)
            : base(instruction, scope, match)
        {
        }

        public string Option { get { return RegexMatch.Groups["option"].Value; } }

        public string Value { get { return RegexMatch.Groups["value"].Value; } }
    }
}
