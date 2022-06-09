using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace R5T.T0136
{
    /// <summary>
    /// Represents a syntax element that has an open brace and a close brace.
    /// </summary>
    public interface IBraced
    {
        public SyntaxToken OpenBrace { get; set; }
        public SyntaxToken CloseBrace { get; set; }
    }
}